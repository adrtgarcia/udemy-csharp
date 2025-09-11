using EX1_CoresEnum;

Console.WriteLine("Exercício Prático 01 - X");

/*
 
    COMPORTAMENTO DO RETURN: 
 
    SOBRECARGA DE MÉTODOS: 

    PASSAGEM DE ARGUMENTOS POR REFERÊNCIA:

    FUNCIONAMENTO DO OUT: 

    USO DO PARÂMETRO OPCIONAL:

    USO DO ARGUMENTO NOMEADO:

    COMPORTAMENTO DO STATIC: 

    DIFERENÇA ENTRE CMAPO E PROPRIEDADE: 
 
 */

Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

chevrolet.ImprimirInformacoes();
ford.ImprimirInformacoes();

chevrolet.Acelerar(chevrolet.marca);
ford.Acelerar(ford.marca);

Console.WriteLine($"\nAumentando a potência do {chevrolet.marca}");
Console.WriteLine($"Potência inicial: {chevrolet.potencia}");
Console.WriteLine($"Potência recebida pelo método: {chevrolet.AumentarPotencia(chevrolet.potencia)}");
Console.WriteLine($"Potência final: {chevrolet.potencia}");

Console.WriteLine($"\nAumentando a potência do {ford.marca}");
Console.WriteLine($"Potência inicial: {ford.potencia}");
Console.WriteLine($"Potência recebida pelo método: {ford.AumentarPotencia(ref ford.potencia)}");
Console.WriteLine($"Potência final: {ford.potencia}");

Console.WriteLine("\nPotência e velocidade");
int novaPotencia = chevrolet.AumentarPotenciaVelocidade(chevrolet.potencia, out double velocidade);
Console.WriteLine($"{chevrolet.marca}: Potência = {novaPotencia}, Velocidade = {velocidade}");
novaPotencia = ford.AumentarPotenciaVelocidade(ford.potencia, out velocidade);
Console.WriteLine($"{ford.marca}: Potência = {novaPotencia}, Velocidade = {velocidade}");

chevrolet.ExibirInfo(modelo: chevrolet.modelo, marca: chevrolet.marca, montadora: chevrolet.montadora, potencia: chevrolet.potencia);
ford.ExibirInfo(modelo: ford.modelo, marca: ford.marca, ano: ford.Ano, montadora: ford.montadora, potencia: ford.potencia);

Console.WriteLine($"Valor do IPVA: {Carro.ObterValorIpva}");

Console.WriteLine("Escolha a cor do carro (1-6):");
int cor = Convert.ToInt32(Console.ReadLine());
chevrolet.cor = cor;
chevrolet.ExibirInfo(modelo: chevrolet.modelo, marca: chevrolet.marca, montadora: chevrolet.montadora, potencia: chevrolet.potencia, cor: cor);

public class Carro
{
    public string? modelo;
    public string? montadora;
    public string? marca;
    private int ano;

    public int Ano 
    {
        get { return ano; }
        set 
        {
            if (value < 2000) ano = 2000;
            else if (value > 2020) ano = 2020;
            else ano = value;
        } 
    }

    public int potencia;
    public static double valorIpva; /* se for internal: , se for private:  */
    public int cor;

    public Carro(string modelo, string montadora, string marca, int ano, int potencia, int cor = 1)
    {
        this.modelo = modelo;
        this.montadora = montadora;
        this.marca = marca;
        this.ano = ano;
        this.potencia = potencia;
        this.cor = cor;
    }

    static Carro()
    {
        valorIpva = 4;
    }

    public Carro(string modelo, string montadora)
    {
        modelo = modelo;
        montadora = montadora;

        /*
        
            Comportamento: 

         */
    }

    public void Acelerar(string marca)
    {
        Console.WriteLine($"\nAcelerando o meu {marca}...");
    }

    public double CalcularVelocidadeMaxima(int potencia)
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

    public void ImprimirInformacoes()
    {
        Console.WriteLine($"\nModelo: {modelo}");
        Console.WriteLine($"Montadora: {montadora}");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Ano: {ano}");
        Console.WriteLine($"Potencia: {potencia}");
    }

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 2025, int cor = 1)
    {
        Console.WriteLine($"\nModelo: {modelo}");
        Console.WriteLine($"Montadora: {montadora}");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Potencia: {potencia}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Cor: {(CoresEnum)cor}");
    }

    public static double ObterValorIpva()
    {
        valorIpva = 4;      /* é possível inicializar com a variável com um construtor estático */
        return valorIpva;
    }
}