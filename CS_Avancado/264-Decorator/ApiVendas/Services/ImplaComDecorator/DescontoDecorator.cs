using ApiVendas.Services.Abstractions;
using ApiVendas.Services.Dados;

namespace ApiVendas.Services.ImplaComDecorator;

public class DescontoDecorator(ICalculadoraPrecoProduto calculadora,
                                  ProdutoRepositorio repositorio) 
                                  : CalculadoraPrecoBaseDecorator(calculadora)
{
    public override decimal Calcular(int produtoId)
    {
        var precoCalculado = base.Calcular(produtoId);
        var produto = repositorio.ObterPorId(produtoId)!;

        if (produto.PrecoBase > 1500)
        {
            var precoFinal = precoCalculado * 0.95m; // Aplica 5% de desconto
            return precoFinal;
        }
        return precoCalculado;
    }
}
