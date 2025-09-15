namespace Exercicios;

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException() { }
    public SaldoInsuficienteException(string? message) : base(message) { }
    public SaldoInsuficienteException(string? message, Exception? innerException) : base(message, innerException) { }
}