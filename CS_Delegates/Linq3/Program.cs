using Linq3;

Console.WriteLine("Consultas LINQ - Localizando um Elemento");

/*

    - First: retorna o primeiro elemento ou o que atenda uma dada condição
        * lança exceção se nenhum elemento for encontrado
    
    - FisrtOrDefault: retorna o primeiro elemento ou o que atenda uma dada condição
        * retorna valor padrão se nenhum elemento for encontrado
      
    - Last: retorna o último elemento ou o que atenda uma dada condição
        * lança exceção se nenhum elemento for encontrado
    
    - LastOrDefault: retorna o último elemento ou o que atenda uma dada condição
        * retorna valor padrão se nenhum elemento for encontrado
    
    - Single: retorna o único elemento que atenda uma dada condição
        * lança exceção se nada for encontrado
        * lança exceção se mais de um elemento atende a condição
      
    - SingleOrDefault: retorna o único elemento que atenda uma dada condição
        * retorna valor padrão se nenhum elemento for encontrado
        * lança exceção se mais de um elemento atende a condição

 */

var produtos = Produto.GetProdutos();
Console.WriteLine("\nLista de produtos:");
Produto.ExibirListaProduto(produtos);

try
{
    Console.WriteLine("\nFirst - produtos.First()");
    var primeiroLista = produtos.First();
    primeiroLista.ExibirInformacaoProduto();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


Console.WriteLine("\nFirstOrDefault - produtos.First(p => p.Nome == 'Camiseta')");
var primeiraCamiseta = produtos.FirstOrDefault(p => p.Nome == "Camiseta");
if (primeiraCamiseta != null)
    primeiraCamiseta.ExibirInformacaoProduto();
else
    Console.WriteLine("Produto não encontrado");

try
{
    Console.WriteLine("\nLast - produtos.Last()");
    var ultimoLista = produtos.Last();
    ultimoLista.ExibirInformacaoProduto();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


Console.WriteLine("\nLastOrDefault - produtos.Last(p => p.Nome == 'Camiseta')");
var ultimaCamiseta = produtos.LastOrDefault(p => p.Nome == "Camiseta");
if (ultimaCamiseta != null)
    ultimaCamiseta.ExibirInformacaoProduto();
else
    Console.WriteLine("Produto não encontrado");

try
{
    Console.WriteLine("\nSingle - produtos.Single(p => p.Preco > 3000)");
    var unicoLista1 = produtos.Single(p => p.Preco > 3000);
    unicoLista1.ExibirInformacaoProduto();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


try
{
    Console.WriteLine("\nSingleOrDefault - produtos.Single(p => p.Estoque > 90)");
    var unicoLista2 = produtos.Single(p => p.Estoque > 90);
    if (unicoLista2 != null)
        unicoLista2.ExibirInformacaoProduto();
    else
        Console.WriteLine("Produto não encontrado");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
