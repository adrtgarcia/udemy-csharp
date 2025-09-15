Console.WriteLine("Exercício - Dictionary");

Dictionary<string, int> alunos = new()
{
    {"Maria", 7 },
    {"Eric", 8 },
    {"Ana", 9 },
    {"Alex", 6 },
    {"Diná", 5 }
};
// abordagem alterantiva: Dictionary<int, Aluno>

Console.WriteLine($"\ndicionário criado com {alunos.Count} alunos\n");
foreach (var aluno in alunos) Console.WriteLine($"Nome: {aluno.Key}\t\t\tNota: {aluno.Value}");

Console.WriteLine("\nmudando a nota de Diná para 8");
Console.WriteLine($"antes: Diná = {alunos["Diná"]}");
alunos["Diná"] = 8;
Console.WriteLine($"depois: Diná = {alunos["Diná"]}");

Console.WriteLine("\nremovendo Eric da coleção");
alunos.Remove("Eric");
Console.WriteLine($"dicionário com {alunos.Count} alunos");

Console.WriteLine("\nincluindo Vilma - 7");
alunos.TryAdd("Vilma", 7);
Console.WriteLine($"dicionário com {alunos.Count} alunos");

Console.WriteLine("\nordenando alunos");
alunos.OrderBy(x => x.Key);

Console.WriteLine("\nremovendo alunos");
alunos.Clear();
Console.WriteLine($"dicionário com {alunos.Count} alunos");