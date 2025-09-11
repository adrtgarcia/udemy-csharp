Console.WriteLine("Métodos estáticos");

Console.WriteLine(Calculadora.Somar(3, 2));
Console.WriteLine(Calculadora.Subtrair(9, 7));
Console.WriteLine(Calculadora.Multiplicar(4, 6));
Console.WriteLine(Calculadora.Dividir(8, 2));


Console.WriteLine("\n\nCampos estáticos");

Cliente c1 = new("maria", 23);
Cliente c2 = new("joão", 26);

c1.ExibirCliente();
c2.ExibirCliente();


Console.WriteLine("\n\nConstrutores estáticos");
// inicializa os membros estáticos da classe

Pessoa p1 = new("maria", 23);
p1.ImprimirInfo();

Pessoa p2 = new("joão", 26);
p2.ImprimirInfo();


public class Calculadora
{
    public static int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }

    public static int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }
    
    public static int Dividir(int num1, int num2)
    {
        return num1 / num2;
    }
}

public class Cliente
{
    public string? nome;
    public int idade;
    public static int agencia = 1234;

    public Cliente(string? nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public void ExibirCliente()
    {
        Console.WriteLine($"{nome}, {idade} anos - agência: {agencia}");
    }
}

public class Pessoa
{
    public static int idadeMinima;
    public string nome { get; set; } = string.Empty;
    public int idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Console.WriteLine("\nExecutando construtor parametrizado");
        this.nome = nome;
        this.idade = idade;
    }

    public Pessoa() { }

    static Pessoa()
    {
        Console.WriteLine("\nExecutando construtor estático");
        idadeMinima = 18;
    }

    public void ImprimirInfo()
    {
        Console.WriteLine($"\n{nome}, {idade} anos \nidade mínima: {idadeMinima}");
    }
}