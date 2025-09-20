using CalculadoraFrete_CP;

namespace CalculadoraDeFrete_CP;
public class CalculadoraDeFrete
{
    private IEstrategiaFrete _estrategia;

    public CalculadoraDeFrete(IEstrategiaFrete estrategia)
    {
        _estrategia = estrategia;
    }

    // Ou trocada em tempo de execução
    public void DefinirEstrategia(IEstrategiaFrete estrategia)
    {
        _estrategia = estrategia;
    }
    public double ExecutarCalculo(Pedido pedido)
    {
        // Delega a chamada para o objeto da estratégia. Sem if-else!
        return _estrategia.Calcular(pedido);
    }
}
