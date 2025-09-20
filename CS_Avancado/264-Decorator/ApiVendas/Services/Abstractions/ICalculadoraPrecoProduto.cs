namespace ApiVendas.Services.Abstractions;

// Interface que será implementada tanto
// pela classe base quanto pelos decorators.
public interface ICalculadoraPrecoProduto
{
    decimal Calcular(int produtoId);
}