namespace CalculadoraFrete_SP;

public class Pedido
{
    public double Valor { get; set; }
    // "sedex", "pac", "transportadora"
    public string? TipoFrete { get; set; } 
}
