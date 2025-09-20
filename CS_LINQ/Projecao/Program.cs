Console.WriteLine("Operadores de Projeção");

List<Aluno> alunos =
[
    new Aluno() { Nome = "maria", Idade = 22, Nota = 7, Cursos = new List<string> { "esof", "ms" } },
    new Aluno() { Nome = "manoel", Idade = 24, Nota = 6, Cursos = new List<string> { "tg", "ms" } },
    new Aluno() { Nome = "amanda", Idade = 21, Nota = 5, Cursos = new List<string> { "gaal", "tc" } },
    new Aluno() { Nome = "carlos", Idade = 20, Nota = 9, Cursos = new List<string> { "tc", "estc" } },
    new Aluno() { Nome = "alice", Idade = 19, Nota = 4, Cursos = new List<string> { "esof", "poo" } }
];

foreach (var a in alunos) Console.WriteLine($"{a.Nome}, nota {a.Nota}");
Console.WriteLine();

var nomesAlunos = alunos.Select(a => a.Nome);
foreach (var a in nomesAlunos) Console.WriteLine($"{a}");
Console.WriteLine();

var nomeIdadeAluno = alunos.Select(a => new Aluno() { Nome = a.Nome, Idade = a.Idade }).ToList();
foreach (var a in nomeIdadeAluno) Console.WriteLine($"{a.Nome}, {a.Idade} anos");
Console.WriteLine();

var alunoAnom = alunos.Select(a => new { NomeAluno = a.Nome, IdadeAluno = a.Idade, NotaAluno = a.Nota }).ToList();
foreach (var a in alunoAnom) Console.WriteLine($"{a.NomeAluno}, {a.IdadeAluno} anos");
Console.WriteLine();

List<Funcionario> funcionarios =
[
    new Funcionario() { Nome = "maria", Idade = 22, Salario = 3200.50m },
    new Funcionario() { Nome = "manoel", Idade = 24, Salario = 4100.50m },
    new Funcionario() { Nome = "amanda", Idade = 21, Salario = 5100.00m },
    new Funcionario() { Nome = "carlos", Idade = 20, Salario = 6200.50m },
    new Funcionario() { Nome = "alice", Idade = 19, Salario = 4100.50m }
];

var funcAnom = funcionarios.Select(f => new { NomeFunc = f.Nome, IdadeFunc = f.Idade, SalarioAnual = (f.Salario * 12) }).ToList();
foreach (var f in funcAnom) Console.WriteLine($"{f.NomeFunc}, {f.IdadeFunc} anos - Salário anual: {f.SalarioAnual:C2}");
Console.WriteLine();

List<List<int>> listasInt = 
[
    new List<int> { 1, 2, 3 },
    new List<int> { 12 },
    new List<int> { 5, 6, 5, 7 },
    new List<int> { 10, 12, 12, 13 }
];

var novaLista = listasInt.SelectMany(lista => lista);
foreach (var l in novaLista) Console.Write(l + "  ");
Console.WriteLine("\n");

var listaCurso1 = alunos.Select(c => c.Cursos);
foreach (List<string> lc in listaCurso1)
{
    foreach (string curso in lc)
    {
        Console.Write($"{curso}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();

var listaCurso2 = alunos.SelectMany(c => c.Cursos);
foreach (string curso in listaCurso2) Console.WriteLine($"{curso}  ");
Console.WriteLine();

public class Aluno
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public int Nota { get; set; }
    public List<string> Cursos { get; set; } = new List<string>();
}
public class Funcionario
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public decimal Salario { get; set; }
}
