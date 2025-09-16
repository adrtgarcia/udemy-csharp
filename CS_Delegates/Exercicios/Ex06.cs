namespace Exercicios;

public static class Operacoes 
{ 
    public static int Operar(int a, int b, Func<int, int, int> operacao)
    {
        return operacao(a, b);
    }
}
