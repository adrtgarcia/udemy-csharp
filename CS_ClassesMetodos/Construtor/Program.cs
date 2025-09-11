Console.WriteLine("Construtores");

Aluno a1 = new Aluno("maria", 22, 'f', true);
Aluno a2 = new Aluno("joão");
Aluno a3 = new Aluno("ana", 21, 'f');

Console.WriteLine($"{a1.nome} {a1.idade} {a1.sexo} {a1.aprovado}");
Console.WriteLine($"{a2.nome} {a2.idade} {a2.sexo} {a2.aprovado}");
Console.WriteLine($"{a3.nome} {a3.idade} {a3.sexo} {a3.aprovado}");

public class Aluno
{
    public string? nome;
    public int idade;
    public char sexo;
    public bool aprovado;

    // public Aluno();

    public Aluno(string nome, int idade, char sexo, bool aprovado)
    {
        this.nome = nome;
        this.idade = idade;
        this.sexo = sexo;
        this.aprovado = aprovado;
    }

    public Aluno(string nome)
    {
        this.nome = nome;
    }

    public Aluno(string nome, int idade, char sexo) : this(nome) 
    {
        this.idade = idade;
        this.sexo = sexo;
        this.aprovado = false;
    }

    public void ImprimirInformacoes(Aluno a)
    {
        Console.WriteLine($"Nome: {a.nome}");
        Console.WriteLine($"Idade: {a.idade}");
        Console.WriteLine($"Sexo: {a.sexo}");
    }
    public void ExibirAluno() => ImprimirInformacoes(this);
}