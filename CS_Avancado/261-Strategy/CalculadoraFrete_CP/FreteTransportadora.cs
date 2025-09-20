using CalculadoraDeFrete_CP;

namespace CalculadoraFrete_CP;

public class FreteTransportadora : IEstrategiaFrete
{
    public double Calcular(Pedido pedido)
    {
        Console.WriteLine("Calculando frete via Transportadora...");
        return pedido.Valor * 0.08 + 15;

    }
}
