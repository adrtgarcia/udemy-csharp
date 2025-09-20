namespace ApiVendas.Entities;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal PrecoBase { get; set; }
}
