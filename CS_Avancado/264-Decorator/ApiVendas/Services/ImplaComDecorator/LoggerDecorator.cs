using ApiVendas.Services.Abstractions;

namespace ApiVendas.Services.ImplaComDecorator;

// Decorator que adiciona o log
public class LoggerDecorator(
    ICalculadoraPrecoProduto calculadora,
    ILogger<LoggerDecorator> logger) : CalculadoraPrecoBaseDecorator(calculadora)
{
    public override decimal Calcular(int produtoId)
    {
        logger.LogInformation("Iniciando cálculo de preço (versão com Decorator)...");

        var precoFinal = base.Calcular(produtoId);

        logger.LogInformation("Cálculo finalizado (versão com Decorator). Preço final: {PrecoFinal}", precoFinal);

        return precoFinal;
    }
}