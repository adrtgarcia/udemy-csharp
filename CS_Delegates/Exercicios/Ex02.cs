namespace Exercicios;

public static class Operacao
{
    public static int Somar(int num1, int num2)

    {
        return num1 + num2;
    }
}

delegate int OperacaoMatematica(int num1, int num2);
