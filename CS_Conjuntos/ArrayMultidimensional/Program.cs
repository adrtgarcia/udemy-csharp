Console.WriteLine("Arrays Multidimensionais");

/*
 
    DECLARAÇÃO:
        tipo [,] nome;        <- bidimensional
        tipo [,,] nome;       <- tridimensional
        tipo [,,,] nome;      <- quadridimensional

 */

int[,] numeros = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };
Console.WriteLine(numeros[1, 2]);
Console.WriteLine(numeros[2, 2]);
Console.WriteLine(numeros[0, 1]);

for (int i = 0; i < numeros.GetLength(0); i++)
{
    for (int j = 0; j < numeros.GetLength(1); j++)
    {
        Console.WriteLine($"numeros[{i}, {j}] = {numeros[i, j]}");
    }
}

foreach (int numero in numeros)
{
    Console.WriteLine($"numero = {numero}");
}

/* uni -> foreach, bi -> for for */

Console.WriteLine("\n\nExercício:");

string[,] alunos = new string[2, 5];
for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"\nInforme o nome do aluno (posição [{i}, {j}]):");
        alunos[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("\nNomes dos alunos:");
for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"alunos[{i}, {j}] = {alunos[i, j]}");
    }
}