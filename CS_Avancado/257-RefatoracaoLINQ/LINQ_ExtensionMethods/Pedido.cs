
public class Pedido
{
    public int Id { get; set; }
    public string? Cliente { get; set; }
    public TipoCliente? TipoCliente { get; set; }
    public StatusPedido? Status { get; set; }
    public decimal Total { get; set; }
}

