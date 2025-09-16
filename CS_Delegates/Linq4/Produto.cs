namespace Linq4;

public class Produto
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public double Preco { get; set; }
    public int Estoque { get; set; }
    public string? Categoria { get; set; }

    public static List<Produto> GetProdutos()
    {
        List<Produto> produtos = new()
        {
            new Produto { Id = 1, Nome = "Camiseta", Preco = 49.99, Estoque = 20, Categoria = "Vestuário" },
            new Produto { Id = 2, Nome = "Meias", Preco = 15.99, Estoque = 40, Categoria = "Vestuário" },
            new Produto { Id = 3, Nome = "Calça", Preco = 90.99, Estoque = 35, Categoria = "Vestuário" },
            new Produto { Id = 4, Nome = "Celular", Preco = 1500.00, Estoque = 25, Categoria = "Eletrônicos" },
            new Produto { Id = 5, Nome = "Notebook", Preco = 2500.00, Estoque = 20, Categoria = "Eletrônicos" },
            new Produto { Id = 6, Nome = "Televisão", Preco = 3500.00, Estoque = 25, Categoria = "Eletrônicos" },
            new Produto { Id = 7, Nome = "Pão francês", Preco = 1.99, Estoque = 100, Categoria = "Alimentação"},
            new Produto { Id = 8, Nome = "Pizza", Preco = 59.99, Estoque = 40, Categoria = "Alimentação"},
            new Produto { Id = 9, Nome = "Refrigerante", Preco = 7.99, Estoque = 50, Categoria = "Alimentação"}
        };
        return produtos;
    }
    public void ExibirInformacaoProduto()
    {
        Console.WriteLine($"{Id}: {Nome}\t\t{Preco.ToString("c")}\t\t{Estoque} unidades\t\t{Categoria}");
    }
    public static void ExibirListaProduto(List<Produto> produtos)
    {
        foreach (Produto p in produtos)
            p.ExibirInformacaoProduto();
    }
}
