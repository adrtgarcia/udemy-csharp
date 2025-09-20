using CalculadoraDeFrete_CP;

namespace CalculadoraFrete_CP;

public interface IEstrategiaFrete
{
    double Calcular(Pedido pedido);
}
