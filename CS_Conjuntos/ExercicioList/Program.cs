Console.WriteLine("Exercício List<T>");

List<Aluno> alunos = new()
{
    new Aluno("Maria", 8.75),
    new Aluno("Manoel", 6.95),
    new Aluno("Amanda", 7.25),
    new Aluno("Carlos", 6.55),
    new Aluno("Jaime", 8.50),
    new Aluno("Debora", 5.95),
    new Aluno("Alicia", 9.25),
    new Aluno("Sandra", 5.55),
    new Aluno("Marta", 7.85),
    new Aluno("Sueli", 9.15)
};

Aluno.ImprimirInfo(alunos);

alunos.Add(new Aluno("Bia", 7.75));
alunos.Add(new Aluno("Mario", 8.95));
Aluno.ImprimirInfo(alunos);

var buscaAluno = alunos.FindIndex(aux => aux.Nome.Equals("Amanda"));
alunos.RemoveAt(buscaAluno);
Aluno.ImprimirInfo(alunos);

var listaOrdenada = alunos.OrderBy(aux => aux.Nome).ToList();
Aluno.ImprimirInfo(listaOrdenada);

var listaNota8 = alunos.FindAll(aux => aux.Nota >= 8);
Aluno.ImprimirInfo(listaNota8);

public class Aluno
{
    public string Nome { get; set; }
    public double Nota { get; set; }

    public Aluno(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public static void ImprimirInfo(List<Aluno> alunos)
    {
        Console.WriteLine("\nImprimindo informações dos alunos...\n");
        int qntAluno = 0;
        double somaNota = 0;
        foreach (Aluno a in alunos)
        {
            qntAluno++;
            somaNota += a.Nota;
            Console.WriteLine($"Nome: {a.Nome} \tNota: {a.Nota}");
        }
        double media = somaNota / qntAluno;
        Console.WriteLine($"\nMédia de notas: {media}");
        Console.WriteLine($"\nTotal de alunos: {qntAluno}");
    }
}
