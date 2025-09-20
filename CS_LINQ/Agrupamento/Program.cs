using System.Threading.Tasks.Sources;

Console.WriteLine("Operadores de Agrupamento");

Console.WriteLine("\nGROUP BY");
/* obs: quando realizamos o agrupamento usando múltiplas chaves, 
   os dados retornados são um tipo anônimo */

List<Aluno> alunos = 
    [
        new Aluno() { Id = 1, Curso = "física", Nome = "joão", Sexo = 'm', Idade = 19 },
        new Aluno() { Id = 2, Curso = "física", Nome = "maria", Sexo = 'f', Idade = 20 },
        new Aluno() { Id = 3, Curso = "matemática", Nome = "josé", Sexo = 'm', Idade = 22 },
        new Aluno() { Id = 4, Curso = "química", Nome = "ana", Sexo = 'f', Idade = 21 },
        new Aluno() { Id = 4, Curso = "química", Nome = "pedro", Sexo = 'm', Idade = 20 },
        new Aluno() { Id = 4, Curso = "matemática", Nome = "paula", Sexo = 'f', Idade = 22 },
    ];
var idades = alunos.GroupBy(a => a.Idade);
foreach (var idade in idades)
{
    Console.WriteLine($"{idade.Key}: {idade.Count()} alunos");
    foreach(var aluno in idade)
    {
        Console.WriteLine($"{aluno.Nome}, {aluno.Curso}");
    }
}
Console.WriteLine();

idades = alunos.GroupBy(a => a.Idade).OrderBy(i => i.Key);
foreach (var idade in idades)
{
    Console.WriteLine($"{idade.Key}: {idade.Count()} alunos");
    foreach (var aluno in idade)
    {
        Console.WriteLine($"{aluno.Nome}, {aluno.Curso}");
    }
}
Console.WriteLine();

var cursos = alunos.GroupBy(a => a.Curso).OrderBy(c => c.Key).Select(std => new { 
    Key = std.Key,
    Alunos = std.OrderBy(x => x.Nome)
});
foreach (var c in cursos)
{
    Console.WriteLine($"{c.Key}: {c.Alunos.Count()} alunos");
    foreach (var a in c.Alunos)
    {
        Console.WriteLine($"{a.Nome} ({a.Idade}, {a.Sexo})");
    }
}
Console.WriteLine();

Console.WriteLine("\nTO LOOK UP");
/* obs: execução imediata */

var aCursos = alunos.ToLookup(a => a.Curso);
foreach (var curso in aCursos)
{
    Console.WriteLine($"\n{curso.Key}: {curso.Count()}");
    foreach (var aluno in curso)
    {
        Console.WriteLine($"{aluno.Nome}, {aluno.Idade} anos");
    }
}
Console.WriteLine();

public class Aluno
{
    public int Id { get; set; }
    public string? Curso { get; set; }
    public string? Nome { get; set; }
    public char Sexo { get; set; }
    public int Idade { get; set; }
}
