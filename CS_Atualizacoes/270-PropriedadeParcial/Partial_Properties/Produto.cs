namespace Partial_Properties;

public partial class Produto
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
    public partial decimal ValorComImposto { get; }
}
