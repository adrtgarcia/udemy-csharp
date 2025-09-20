namespace Partial_Properties;

public partial class Produto
{
    private decimal _taxaImposto = 0.18m;

    public partial decimal ValorComImposto
    {
        get
        {
            return Preco * (1 + _taxaImposto);
        }
    }
}
