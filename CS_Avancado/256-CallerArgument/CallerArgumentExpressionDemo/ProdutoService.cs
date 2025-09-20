namespace CallerArgumentExpressionDemo;

public class ProdutoService
{
    public void AdicionarProduto(string nome, decimal preco)
    {
        //Validação
        Validador.NotNullOrEmpty(nome, nameof(nome));
        Validador.MaiorQueZero(preco, nameof(preco));
        //Adicionar Produto
        Console.WriteLine($"Produto '{nome}' adicionado com preço R$ {preco:F2}");
    }

    public void AtualizarPreco(int produtoId, decimal novoPreco)
    {
        //Validação
        Validador.MaiorQueZero(produtoId, nameof(produtoId));
        Validador.MaiorQueZero(novoPreco, nameof(novoPreco));
        //Atualizar Produto
        Console.WriteLine($"Preço do produto {produtoId} atualizado para R$ {novoPreco:F2}");
    }
}
