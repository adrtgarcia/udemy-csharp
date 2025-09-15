/* refazendo o exercício, dessa vez utilizando a classe Aluno */

Dictionary<int, Aluno> alunos = new()
{
    { 1, new Aluno("Maria", 7) },
    { 2, new Aluno("Eric", 8) },
    { 3, new Aluno("Ana", 9) },
    { 4, new Aluno("Alex", 6) },
    { 5, new Aluno("Diná", 5) }
};

foreach (var aluno in alunos) Console.WriteLine($"Nome: {aluno.Value.Nome}\t\t\tNota: {aluno.Value.Nota}");
Console.WriteLine($"\nNúmero de alunos: {alunos.Count}");

Console.WriteLine("\nmudando a nota de Diná para 8...\n");
Console.WriteLine($"antes: Diná, nota {alunos[5].Nota}");
alunos[5].Nota = 8;
Console.WriteLine($"depois: Diná, nota {alunos[5].Nota}");
foreach (var aluno in alunos) Console.WriteLine($"Nome: {aluno.Value.Nome}\t\t\tNota: {aluno.Value.Nota}");
Console.WriteLine($"\nNúmero de alunos: {alunos.Count}");

Console.WriteLine("\nremovendo Eric da coleção...\n");
alunos.Remove(2);
foreach (var aluno in alunos) Console.WriteLine($"Nome: {aluno.Value.Nome}\t\t\tNota: {aluno.Value.Nota}");
Console.WriteLine($"\nNúmero de alunos: {alunos.Count}");

Console.WriteLine("\nincluindo Vilma - 7...\n");
alunos.TryAdd(6, new Aluno("Vilma", 7));
foreach (var aluno in alunos) Console.WriteLine($"Nome: {aluno.Value.Nome}\t\t\tNota: {aluno.Value.Nota}");
Console.WriteLine($"\nNúmero de alunos: {alunos.Count}");

Console.WriteLine("\nordenando alunos pelo nome...\n");
alunos.OrderBy(x => x.Value.Nome);
foreach (var aluno in alunos) Console.WriteLine($"Nome: {aluno.Value.Nome}\t\t\tNota: {aluno.Value.Nota}");
Console.WriteLine($"\nNúmero de alunos: {alunos.Count}");

Console.WriteLine("\nremovendo alunos...\n");
alunos.Clear();
foreach (var aluno in alunos) Console.WriteLine($"Nome: {aluno.Value.Nome}\t\t\tNota: {aluno.Value.Nota}");
Console.WriteLine($"\nNúmero de alunos: {alunos.Count}");

public class Aluno
{
    public string? Nome { get; set; }
    public int Nota { get; set; }
    public Aluno(string? nome, int nota)
    {
        Nome = nome;
        Nota = nota;
    }
}