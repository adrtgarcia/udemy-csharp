namespace Exercicios;

public static class ListExtensions
{
    public static int SomaImpar(List<int> inteiros)
    {
        int soma = 0;
        foreach (int i in inteiros)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }
        return soma;
    }
}
