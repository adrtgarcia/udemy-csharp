namespace ApiVendas.Services.Abstractions;

// Decorator abstrato para evitar código repetido.
public abstract class CalculadoraPrecoBaseDecorator(
       ICalculadoraPrecoProduto calculadora) : ICalculadoraPrecoProduto
{
    public virtual decimal Calcular(int produtoId)
    {
        return calculadora.Calcular(produtoId);
    }
}