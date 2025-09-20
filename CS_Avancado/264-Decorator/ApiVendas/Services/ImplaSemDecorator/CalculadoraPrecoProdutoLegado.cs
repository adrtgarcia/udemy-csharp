using ApiVendas.Services.Dados;

namespace ApiVendas.Services.ImplaSemDecorator;

// Abordagem tradicional, sem Decorator.
public class CalculadoraPrecoProdutoLegado(ProdutoRepositorio repositorio,
                                    ILogger<CalculadoraPrecoProdutoLegado> logger)
{
    public decimal Calcular(int produtoId)
    {
        logger.LogInformation("Iniciando cálculo de preço (versão legado)...");

        var produto = repositorio.ObterPorId(produtoId);

        if (produto == null)
        {
            logger.LogError("Produto com ID {ProdutoId} não encontrado.", produtoId);
            throw new Exception("Produto não encontrado.");
        }

        decimal precoFinal = produto.PrecoBase;
        logger.LogInformation("Preço base: {PrecoBase}", precoFinal);

        // Regra 1: Adicionar Imposto (10%)
        decimal imposto = precoFinal * 0.10m;
        precoFinal += imposto;
        logger.LogInformation("Após imposto (10%): {PrecoFinal}", precoFinal);

        // Nova Regra 2: Adicionar Frete para produtos abaixo de 200
        if (produto.PrecoBase < 200)
        {
            precoFinal += 25; // Frete fixo de 25
            logger.LogInformation("Após frete (R$25): {PrecoFinal}", precoFinal);
        }

        logger.LogInformation("Cálculo finalizado (versão legado). Preço final: {PrecoFinal}", precoFinal);
        return precoFinal;
    }
}