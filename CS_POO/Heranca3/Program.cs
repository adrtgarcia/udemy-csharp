Console.WriteLine("Herança - Construtores");

Aluno a = new();
Aluno b = new("maria");
Aluno c = new("joão", "ufu");

public class Aluno : Pessoa
{
    public Aluno()
    {
        Console.WriteLine("\nconstrutor aluno ok");
    }
    public Aluno(string nome)
    {
        Console.WriteLine($"\nconstrutor aluno com nome {nome} ok");
    }
    public Aluno(string nome, string faculdade) : base(nome)
    {
        Console.WriteLine($"\nconstrutor aluno com {nome} e {faculdade} ok");
        Console.WriteLine($"passando {nome} para construtor pessoa");
    }
}

public class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("construtor pessoa ok");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine($"construtor pessoa com nome {nome} ok");
    }
}
