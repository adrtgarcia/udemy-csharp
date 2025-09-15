namespace Exercicios;

public static class Exemplo
{
    public static void ReverterEImprimir<T>(T[] vetor)
    {
        Array.Reverse(vetor);
        foreach (T item in vetor) { Console.Write(item + "  "); }
        Console.WriteLine("\n");
    }
}
