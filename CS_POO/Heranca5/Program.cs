Console.WriteLine("Herança - New");

Aluno a = new("Maria", 21, "Computação");
a.ExibirInfo();

public class Aluno : Pessoa
{
    public string? Curso { get; set; }

    public Aluno(string nome, int idade, string curso) : base(nome, idade)
    {
        Curso = curso;
    }

    public new void ExibirInfo()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos.");
        Console.WriteLine($"Sou estudante do curso de {Curso}.");
    }
}

public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos.");
    }
}