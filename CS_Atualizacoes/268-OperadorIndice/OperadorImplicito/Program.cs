
var vetor = new InicializaArray
{
    Inteiros =
    {
      [0] = 500,  // Modifica o primeiro elemento
      [^3]=  300, // Modifica o antepenúltimo elemento
      [^2] = 200, // Modifica o penúltimo elemento
      [^1] = 100  // Modifica o último elemento
    }
};

Console.WriteLine(string.Join(" ", vetor.Inteiros));

Console.WriteLine($"O valor de vetor.Inteiros[1] é {vetor.Inteiros[1]}");
Console.WriteLine($"O valor de vetor.Inteiros[3] é {vetor.Inteiros[^2]}");
Console.WriteLine($"O valor de vetor.Inteiros[4] é {vetor.Inteiros[^1]}");

Console.ReadLine();

class InicializaArray
{
    // Inicializa com um array de 5 elementos
    public int[] Inteiros { get; set; } = new int[5];
}