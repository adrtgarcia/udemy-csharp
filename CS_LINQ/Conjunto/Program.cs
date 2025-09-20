Console.WriteLine("Operações com Conjuntos");

Console.WriteLine("\nDISTINCT");

var idades = new[] { 30, 33, 35, 36, 40, 30, 33, 36, 30, 40 };
var idadesDistintas = idades.Distinct();
foreach (var i in idadesDistintas) Console.Write(i + "  ");
Console.WriteLine("\n");

string[] nomes = { "Maria", "JOÃO", "maria", "José", "joão", "josé" };
var nomesDistintos1 = nomes.Distinct();
foreach (var n in nomesDistintos1) Console.Write(n + "  ");
Console.WriteLine("\n");
var nomesDistintos2 = nomes.Distinct(StringComparer.OrdinalIgnoreCase);
foreach (var n in nomesDistintos2) Console.Write(n + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nDISTINCT BY");

List<Aluno> alunos =
[
    new Aluno() { Nome = "maria", Idade = 20},
    new Aluno() { Nome = "joão", Idade = 22},
    new Aluno() { Nome = "ana", Idade = 23},
    new Aluno() { Nome = "josé", Idade = 20},
    new Aluno() { Nome = "paulo", Idade = 23}
];
var alunoIdadeDistinta = alunos.DistinctBy(a => a.Idade);
foreach (var a in alunoIdadeDistinta) Console.WriteLine($"{a.Nome}, {a.Idade} anos");
Console.WriteLine();

Console.WriteLine("\nEXCEPT");

List<int> lNum1 = [ 1, 2, 3, 4, 5, 6 ];
List<int> lNum2 = [ 1, 3, 5, 8, 9, 0 ];
var rExc = lNum1.Except(lNum2).ToList();
foreach (var r in rExc) Console.Write(r + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nEXCEPT BY");
var alunoReprovado = new[] { "joão", "ana" };
var alunoAprovado = alunos.ExceptBy(alunoReprovado, a => a.Nome);
foreach (var a in alunoAprovado) Console.Write(a.Nome + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nINTERSECT");

var rInt = lNum1.Intersect(lNum2).ToList();
foreach (var r in rInt) Console.Write(r + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nINTERSECT BY");

List<Aluno> turmaA = alunos;
List<Aluno> turmaB = 
[
    new Aluno() { Nome = "marina", Idade = 20},
    new Aluno() { Nome = "jorge", Idade = 21},
    new Aluno() { Nome = "alice", Idade = 21},
    new Aluno() { Nome = "mateus", Idade = 20},
    new Aluno() { Nome = "bianca", Idade = 22}
];
var turmaIdade = turmaA.IntersectBy(turmaB.Select(a => a.Idade), a => a.Idade);
foreach (var i in turmaIdade) Console.Write(i.Nome + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nUNION");

var rUni = lNum1.Union(lNum2).ToList();
foreach (var r in rUni) Console.Write(r + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nUNION BY");

var turmas = turmaA.UnionBy(turmaB, a => a.Nome).ToList();
foreach (var a in turmas) Console.Write($"{a.Nome}, {a.Idade} anos");
Console.WriteLine("\n");

public class Aluno
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
}
