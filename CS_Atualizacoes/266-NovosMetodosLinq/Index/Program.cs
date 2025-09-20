Console.WriteLine("\nIndex\n");

var alunos = new[]
{
   "Jose Sanches",
   "Janice Pereira",
   "Carlos Nogueira",
   "João Silveira"
};

foreach (var (index, aluno) in alunos.Index())
    Console.WriteLine($"Aluno {index}: {aluno}");

Console.ReadLine();




