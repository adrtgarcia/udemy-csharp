namespace Exercicios;

public static class Calculadora<T> where T : struct, IComparable, IConvertible, IFormattable
{
    public static T Somar(T num1, T num2)
    {
        dynamic d1 = num1;
        dynamic d2 = num2;
        return d1 + d2;
    }
}
