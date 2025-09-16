using Linq4;

Console.WriteLine("Consultas LINQ - Agrupamento");

/*
 
    - GroupBy: agrupa os elementos de uma sequência
        * o agrupamento é dado por um objeto IGrouping<TKey, T>
        * TKey é a chave, T é o elemento que será agrupado
        * para uma chave composta, definimos um tipo anônimo usando NEW
        * retorna um IEnumerable<IGrouping<TKey, TSource>>
    
 */

var produtos = Produto.GetProdutos();
Console.WriteLine("\nLista de Produtos:");
Produto.ExibirListaProduto(produtos);

Console.WriteLine("\nProdutos por categoria:");
var produtosCategoria = produtos.GroupBy(p => p.Categoria);
foreach (var grupo in produtosCategoria)
{
    Console.WriteLine($"{grupo.Key} - {grupo.Count()}");
    
    foreach (var produto in grupo)
    {
        produto.ExibirInformacaoProduto();
    }
}

Console.WriteLine("\nProdutos ordenados por categoria:");
var produtosOrdenados = produtos.GroupBy(p => p.Categoria)
                                .OrderBy(c => c.Key)
                                .Select(g => new
                                {
                                    Categoria = g.Key,
                                    Produtos = g.OrderBy(p => p.Nome)
                                                .Select(p => new
                                                {
                                                    Nome = p.Nome,
                                                    Preco = p.Preco,
                                                    Estoque = p.Estoque
                                                })
                                });
/*                               
foreach (var grupo in produtosCategoria);
{
    Console.WriteLine($"{grupo.Key} - {grupo.Count()}");

    foreach (var produto in grupo)
    {
        produto.ExibirInformacaoProduto();
    }
}
*/

foreach (var grupo in produtosOrdenados)
{
    Console.WriteLine($"\n{grupo.Categoria}\n");

    foreach (var produto in grupo.Produtos)
    {
        Console.WriteLine($"{produto.Nome}\t\t{produto.Preco:C2}\t\t{produto.Estoque} unidades");
    }
}
