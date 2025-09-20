namespace CalculadoraFrete_SP;

public class CalculadoraDeFrete
{
    public double Calcular(Pedido pedido)
    {
        // Se o frete for Sedex
        if (pedido.TipoFrete!.Equals("sedex", StringComparison.OrdinalIgnoreCase))
        {
            // Lógica complexa para Sedex
            Console.WriteLine("Calculando frete via Sedex...");
            return pedido.Valor * 0.1 + 10;
        }
        // Se for PAC
        else if (pedido.TipoFrete.Equals("pac", StringComparison.OrdinalIgnoreCase))
        {
            // Lógica complexa para PAC
            Console.WriteLine("Calculando frete via PAC...");
            return pedido.Valor * 0.05 + 5;
        }
        // Se for Transportadora
        else if (pedido.TipoFrete.Equals("transportadora", StringComparison.OrdinalIgnoreCase))
        {
            // Lógica complexa para Transportadora
            Console.WriteLine("Calculando frete via Transportadora...");
            return pedido.Valor * 0.08 + 15;
        }
        else // caso o tipo de frete não seja válido
        {
            throw new ArgumentException("Tipo de frete inválido!");
        }
    }
}
