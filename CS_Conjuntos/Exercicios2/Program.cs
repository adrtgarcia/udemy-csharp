Console.WriteLine("Exercício 02");

Random random = new();

Console.WriteLine("\nInforme o tamanho do array: ");
int tamanho = Convert.ToInt32(Console.ReadLine());

int[] numeros = new int[tamanho];
for (int i = 0; i < tamanho; i++)
{
    int numAleatorio = random.Next(1, 21);
    numeros[i] = numAleatorio;
}

while(true)
{
    Console.WriteLine("\nInforme um número: ");
    int numProcurado = Convert.ToInt32(Console.ReadLine());
    if (numeros.Contains(numProcurado))
        Console.WriteLine($"{numProcurado} existe no array");
    else
        Console.WriteLine($"{numProcurado} não existe no array");
    
    Console.WriteLine("\nDigite 'fim' para encerrar: ");
    var resposta = Console.ReadLine();
    if (resposta == "fim")
        break;
}
