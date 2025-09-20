using ApiVendas.Services.Abstractions;
using ApiVendas.Services.Dados;

namespace ApiVendas.Services.ImplaComDecorator;

// Também recebe ILogger.
public class FreteDecorator(
    ICalculadoraPrecoProduto calculadora,
    ProdutoRepositorio repositorio,
    ILogger<FreteDecorator> logger) : CalculadoraPrecoBaseDecorator(calculadora)
{
    public override decimal Calcular(int produtoId)
    {
        var precoCalculado = base.Calcular(produtoId);

        //Busca o produto original para checar sua propriedade "PrecoBase".
        var produto = repositorio.ObterPorId(produtoId)!;

        if (produto.PrecoBase < 200)
        {
            var precoFinal = precoCalculado + 15;
            logger.LogInformation("Após frete (R$15): {PrecoFinal}", precoFinal);
            return precoFinal;
        }

        return precoCalculado;
    }
}

