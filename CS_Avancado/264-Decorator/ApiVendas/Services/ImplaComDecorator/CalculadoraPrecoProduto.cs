using ApiVendas.Services.Dados;
using ApiVendas.Services.Abstractions;

namespace ApiVendas.Services.ImplaComDecorator;

public class CalculadoraPrecoProduto(ProdutoRepositorio repositorio ) 
    : ICalculadoraPrecoProduto
{
    public decimal Calcular(int produtoId)
    {
        var produto = repositorio.ObterPorId(produtoId) 
                          ?? throw new Exception("Produto não encontrado.");

        return produto.PrecoBase;
    }
}
