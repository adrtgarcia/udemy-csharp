
Produto produto = new();

produto.Preco = -10;

Console.WriteLine($"Preço do produto : {produto.Preco}");

Console.ReadLine();

public class Produto
{
    public decimal Preco
    {
        get;
        set => field = value < 0 ? throw new ArgumentException("O preço não pode ser negativo.")
            : value;
    }
}

