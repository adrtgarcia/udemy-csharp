Console.WriteLine("Random");

Random random = new Random();               // seed criada a partir do relógio do sistema

Console.WriteLine(random.Next());           // padrão
Console.WriteLine(random.Next(20));         // limite máximo
Console.WriteLine(random.Next(0, 20));      // intervalo 0-19 (min, max-1)
Console.WriteLine(random.NextDouble());     // intervalo 0-1
Console.WriteLine("\n\n\n");

byte[] randBytes = new byte[10];
random.NextBytes(randBytes);
foreach (byte b in randBytes) Console.Write(b + "   ");
Console.WriteLine("\n\n\n");

int[] sorteados = new int[6];
for (int i = 0; i < 6; i++)
{
    int numAleatorio;
    do
    {
        numAleatorio = random.Next(1, 61);
    } while (sorteados.Contains(numAleatorio));

    sorteados[i] = numAleatorio;
}
Array.Sort(sorteados);
foreach (int i in sorteados) Console.Write(i + " ");