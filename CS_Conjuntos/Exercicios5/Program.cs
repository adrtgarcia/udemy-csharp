Console.WriteLine("Exercício 05\n");

List<Produto> produtos = new()
{
    new Produto("Clips", 3.95m),
    new Produto("Caneta", 5.99m),
    new Produto("Lápis", 4.15m),
    new Produto("Estojo", 6.99m),
    new Produto("Caderno", 7.55m)

};

Produto.ExibirInfo(produtos);

produtos.Add(new Produto("Mochila", 22.44m));
Produto.ExibirInfo(produtos);

var listaOrdenada = produtos.OrderBy(aux => aux.Nome).ToList();
Produto.ExibirInfo(listaOrdenada);

var listaPreco = produtos.OrderBy(aux => aux.Preco < 5).ToList();
Produto.ExibirInfo(listaPreco);

var buscaEstojo = produtos.Find(aux => aux.Nome.Equals("Estojo"));
Console.WriteLine($"Produto: {buscaEstojo.Nome} - R$ {buscaEstojo.Preco}");

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public static decimal CalcularPrecoTotal(List<Produto> produtos)
    {
        decimal total = 0;
        foreach (Produto p in produtos) total += p.Preco;
        return total;
    }

    public static decimal CalcularMediaPreco(List<Produto> produtos)
    {
        decimal media = CalcularPrecoTotal(produtos) / ContarProdutos(produtos);
        return media;
    }

    public static int ContarProdutos(List<Produto> produtos)
    {
        int quantidade = produtos.Count;
        return quantidade;
    }

    public static void ExibirInfo(List<Produto> produtos)
    {
        foreach (Produto p in produtos) Console.WriteLine($"{p.Nome} - R$ {p.Preco.ToString("c")}");
        Console.WriteLine($"\nPreço total: R$ {CalcularPrecoTotal(produtos).ToString("c")}");
        Console.WriteLine($"Média de preço dos produtos: R$ {CalcularMediaPreco(produtos).ToString("c")}");
        Console.WriteLine($"Quantidade de produtos na lista: {ContarProdutos(produtos)}\n");
    }
}