Console.WriteLine("Exercício 03");

float[,] notas = new float[2, 5];

float media = 0;

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine($"\nDigite a nota do aluno {j + 1} do grupo {i + 1}");
        notas[i, j] = Convert.ToSingle(Console.ReadLine());
        media += notas[i, j];
    }

    media /= 5;
    Console.WriteLine($"\nMédia das notas do grupo {i + 1}: {media}");

    media = 0;
}
