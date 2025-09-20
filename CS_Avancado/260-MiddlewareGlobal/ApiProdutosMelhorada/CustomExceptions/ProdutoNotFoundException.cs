namespace ApiProdutosMelhorada.CustomExceptions;

public class ProdutoNotFoundException : Exception
{
    public ProdutoNotFoundException(string message) : base(message) { }
}
