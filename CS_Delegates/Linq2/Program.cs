using Linq2;
Console.WriteLine("Consultas LINQ - Filtrando Elementos");

/*
 
    WHERE: método de extensão que filtra uma coleção de objetos com base em uma condição
        - extensão da interface IEnumerable<T>, recebe como argumento uma expressão lambda que 
          define a condição de filtro
        - a expressão lambda deve conter um único parâmetro do tipo T e retornar um booleano que
          indica se o elemento atende ou não a condição
 
    operadores de consulta que podem ser usados com WHERE:
        - OrderBy e ThenBy (ordenação)
        - Sum, Average e Count (cálculos)
        - Select (projeta e transformar dados, cria tipos anônimos e nova coleção)
 
 */

var produtos = Produto.GetProdutos();
Console.WriteLine("\nLista de Produtos:");
Produto.ExibirListaProduto(produtos);

Console.WriteLine("\nBuscando produtos eletrônicos");
var produtosEletronicos = produtos
                  .Where(p => p.Categoria == "Eletrônicos")
                  .ToList();
Produto.ExibirListaProduto(produtosEletronicos);

Console.WriteLine("\nBuscando produtos mais caros, com estoque maior que 20");
var produtosCaros = produtos.Where(p => (p.Preco >= 1000) && (p.Estoque > 20)).ToList();
Produto.ExibirListaProduto(produtosCaros);

Console.WriteLine("\nBuscando produtos com estoque menor que 30, em ordem alfabética");
var estoqueBaixo = produtos.Where(p => p.Estoque < 30).OrderBy(p => p.Nome).ToList();
Produto.ExibirListaProduto(estoqueBaixo);

Console.WriteLine("\nOrdenando produtos por categoria e nome");
var produtosOrdenados = produtos.OrderBy(p => p.Categoria).ThenBy(p => p.Nome).ToList();
Produto.ExibirListaProduto(produtosOrdenados);

Console.WriteLine("\nCriando lista apenas com os nomes ordenados");
var nomesProdutos = produtos.Select(p => p.Nome).OrderBy(p => p);
foreach (string? n in nomesProdutos)
    Console.WriteLine(n);

Console.WriteLine("\nCriando lista apenas com produtos baratos, ordenados por nome");
var produtosBaratos = produtos.Where(p => p.Preco < 100).OrderBy(p => p.Nome).Select(p => new { Nome = p.Nome, Preco = p.Preco });
foreach (var p in produtosBaratos)
    Console.WriteLine($"{p.Nome}\t\t\t{p.Preco:C2}");

Console.WriteLine("\nObtendo valor médio dos produtos eletrônicos");
var mediaEletronicos = produtos.Where(p => p.Categoria == "Eletrônicos").Average(p => p.Preco);
Console.WriteLine($"Valor médio: {mediaEletronicos:C2}");

Console.WriteLine("\nObtendo valor total do estoque");
var totalEstoque = produtos.Sum(p => p.Preco * p.Estoque);
Console.WriteLine($"Valor total: {totalEstoque:C2}");

Console.WriteLine("\nObtendo total de itens no estoque");
var totalProdutos = produtos.Sum(p => p.Estoque);
Console.WriteLine($"Total de itens: {totalProdutos}");
