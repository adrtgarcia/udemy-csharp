using CalculadoraDeFrete_CP;

namespace CalculadoraFrete_CP;

public class FreteSedex : IEstrategiaFrete
{
    public double Calcular(Pedido pedido)
    {
        Console.WriteLine("Calculando frete via Sedex...");
        return pedido.Valor * 0.1 + 10;

    }
}
