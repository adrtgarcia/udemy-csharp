using CalculadoraDeFrete_CP;

namespace CalculadoraFrete_CP;

public class FretePac : IEstrategiaFrete
{
    public double Calcular(Pedido pedido)
    {
        Console.WriteLine("Calculando frete via PAC...");
        return pedido.Valor * 0.05 + 5;

    }
}
