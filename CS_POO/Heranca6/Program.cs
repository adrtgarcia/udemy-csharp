Console.WriteLine("Herança - Virtual e Override");

/*
 
    para que um membro da subclasse substitua um membro com mesmo nome
    da classe base, é preciso:
        1) usar o modificador VIRTUAL na declaração do membro da classe base
        2) usar o modificador OVERRIDE na declaração do membro da classe derivada
 
 */

Aluno a = new();
a.Nome = "Maria";
a.Curso = "Computação";
a.Saudacao();

class Pessoa
{
    public string? Nome { get; set; }
    public virtual string Saudacao() 
        => $"Oi, meu nome é {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public override string Saudacao()
        => $"Oi, meu nome é {Nome}, sou estudante de {Curso}";
}