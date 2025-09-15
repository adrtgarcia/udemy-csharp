namespace ExcecaoPersonalizada3;

public class DepositoNegativoException : Exception
{
    public DepositoNegativoException() { }
    public DepositoNegativoException(string? message) : base(message) { }
    public DepositoNegativoException(string? message, Exception? innerException) : base(message, innerException) { }
   
    public override string Message
    {
        get
        {
            return "Não é possível depositar um valor negativo";
        }
    }
}
