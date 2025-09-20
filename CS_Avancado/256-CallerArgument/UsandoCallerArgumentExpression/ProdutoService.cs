namespace UsandoCallerArgumentExpression;

public class ProdutoService
{
    public void AdicionarProduto(string nome, decimal preco)
    {
        //Validação
        

        //Adicionar Produto
        Console.WriteLine($"Produto '{nome}' adicionado com preço R$ {preco:F2}");
    }

    public void AtualizarPreco(int produtoId, decimal novoPreco)
    {
        //Validação

        //Atualizar Produto
        Console.WriteLine($"Preço do produto {produtoId} atualizado para R$ {novoPreco:F2}");
    }
}
