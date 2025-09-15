namespace Exercicios;

public class Aluno
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public char Sexo { get; set; }

    public Aluno(string? nome, int idade, char sexo)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }

    public void Exibir()
    {
        Console.WriteLine($"{Nome}\t\t{Idade} anos\t({Sexo})");
    }
}
