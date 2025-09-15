namespace ExcecaoPersonalizada3;

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException() { }
    public SaldoInsuficienteException(string? message) : base(message) { }
    public SaldoInsuficienteException(string? message, Exception? innerException) : base(message, innerException) { }
    public SaldoInsuficienteException(decimal valorSaque, decimal saldoConta) 
        : base($"O valor do saque {valorSaque.ToString("c")} é superior ao valor do saldo {saldoConta.ToString("c")}") { }
}
