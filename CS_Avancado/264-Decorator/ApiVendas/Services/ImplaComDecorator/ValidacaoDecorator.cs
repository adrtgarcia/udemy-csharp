using ApiVendas.Services.Abstractions;
using ApiVendas.Services.Dados;

namespace ApiVendas.Services.ImplaComDecorator;

public class ValidacaoDecorator(ICalculadoraPrecoProduto calculadora,
    ProdutoRepositorio repositorio) : CalculadoraPrecoBaseDecorator(calculadora)
{
    public override decimal Calcular(int produtoId)
    {
        var produto = repositorio.ObterPorId(produtoId);
        if (produto == null)
        {
            throw new Exception($"[Validação Decorator] Produto com ID {produtoId} não existe.");
        }
        // Se existe, continua a execução.
        return base.Calcular(produtoId);
    }
}
