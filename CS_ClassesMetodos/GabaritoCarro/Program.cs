Console.WriteLine("Gabarito: Exercício Prático 1");

/*
 
    RETURN:
        usado para encerrar a execução do método e retornar o controle de volta ao método chamador, 
        retornando o valor do tipo definido no método

    SOBRECARGA DE MÉTODOS:
        significa ter dois ou mais métodos com mesmo nome, mas com assinaturas diferentes

    ASSINATURA DE MÉTODO:
        nome do método + número de parâmetros + tipo de parâmetros + ordem dos parâmetros

    ARGUMENTO POR REFERÊNCIA (REF):
        por meio da palavra-chave ref, o valor do parâmetro é alterado no método, 
        pois o método recebe uma cópia do endereço do parâmetro na memória
 
    ARGUMENTO POR REFERÊNCIA (OUT): 
        por meio da palavra-chave out, o argumento pode ser passado sem atribuir nenhum valor a ele,
        e deve ser inicializado no método chamado antes de retornar ao método chamador
            - dessa forma, podemos obter mais de um retorno em um mesmo método

    PARÂMETROS OPCIONAIS:
        podem ser omitidos na chamada do método, pois são definidos com um valor padrão constante
            - devem ser definidos depois dos parâmetros normais

    ARGUMENTOS NOMEADOS:
        permitem a especificação de um argumento para um parâmetro correspondendo o argumento com seu nome,
        em vez de sua posição na lista de parâmetros

    STATIC:
        permite declarar um membro estático que pertence ao próprio tipo, e não a um objeto específico

    PROPRIEDADES:
        permitem que uma classe exponha uma forma pública de obter e definir valores, enquanto 
        oculta o código de implementação ou de verificação
            - CAMPO: variável de qualquer tipo declarada diretamente na classe
            - PROPRIEDADE: membro que fornece mecanismo flexível para ler, gravar ou calcular o valor de um campo privado

 */

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110, 2);
Console.WriteLine($"\n{chevrolet.Modelo} {chevrolet.Montadora} {chevrolet.Marca} {chevrolet.Ano} {chevrolet.Potencia}CV {chevrolet.Cor}");
chevrolet.Acelerar();
chevrolet.Acelerar(chevrolet.Marca);
Console.WriteLine($"Aumentando a potência (por valor, +3CV): {chevrolet.AumentarPotencia(chevrolet.Potencia)}CV");
Console.WriteLine($"Verificando potência: {chevrolet.Potencia}CV");
double velocidade;
Console.WriteLine($"Aumentando potência (por valor, +7CV) e velocidade (por referência out): ");
Console.WriteLine($"Potência: {chevrolet.AumentarPotenciaVelocidade(chevrolet.Potencia, out velocidade)}CV - Velocidade: {velocidade}");

Carro ford = new("SUV", "Ford", "EcoSport", 2012, 120, 4);
Console.WriteLine($"\n{ford.Modelo} {ford.Montadora} {ford.Marca} {ford.Ano} {ford.Potencia} CV {ford.Cor}");
Carro ford2 = new("SUV", "Ford");
Console.WriteLine($"{ford2.Modelo} {ford2.Montadora} {ford2.Marca} {ford2.Ano} {ford2.Potencia} CV");
ford.Acelerar();
ford.Acelerar(ford.Marca);
Console.WriteLine($"Aumentando a potência (por referência ref, +5CV): {ford.AumentarPotencia(ford.Potencia)}CV");
Console.WriteLine($"Verificando potência: {ford.Potencia}CV");
ford.ExibirInfo(modelo: ford.Modelo, montadora: ford.Montadora, marca: ford.Marca, potencia: ford.Potencia);
ford.ExibirInfo(modelo: ford.Modelo, montadora: ford.Montadora, marca: ford.Marca, potencia: ford.Potencia, ano: ford.Ano);

/* Carro.ObterValorIpva(); */
Console.WriteLine($"Valor do campo ValorIpva = {Carro.ValorIpva}");

public enum Cores
{
    Branco = 1,
    Vermelho,
    Preto,
    Cinza,
    Prata,
    Azul
}

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    /* public int Ano; */
    public int Potencia;
    public int Cor;
    public static double ValorIpva;     /* <- se fosse internal, não traria nenhuma alteração na execução, continuaria sendo acessível no mesmo assembly (mas não fora dele) */
                                        /*    se fosse private, seria acessível somente dentro da classe (afetaria linha 65) */                
    private int ano;
    public int Ano
    {
        get { return ano; }
        set
        {
            if (value < 2000) ano = 2000;
            else if (value > 2022) ano = 2022;
            else ano = value;
        }
    }

    static Carro()
    {
        ValorIpva = 4;
    }

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia, int cor)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
        Cor = cor;
    }

    public Carro(string? modelo, string? montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }
        
    public void Acelerar()
    {
        Console.WriteLine("\nAcelerando...");
    }
    
    public void Acelerar(string marca)
    {
        Console.WriteLine($"\nAcelerando meu {marca}...");
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    public int AumentarPotencia(int potencia)
    {
        potencia += 3;
        return potencia;
    }

    public int AumentarPotencia(ref int potencia)
    {
        potencia += 5;
        return potencia;
    }

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }

    public void ExibirInfo(string? modelo, string? montadora, string? marca, int potencia, int Cor = 1, int ano = 2022)
    {
        Console.WriteLine($"{modelo} {montadora} {marca} {potencia}CV {ano} {(Cores)Cor}");
    }

    /* 
    public static void ObterValorIpva()     <- pode ser substituído por um construtor estático
    {
        ValorIpva = 4;
    }
    */
}