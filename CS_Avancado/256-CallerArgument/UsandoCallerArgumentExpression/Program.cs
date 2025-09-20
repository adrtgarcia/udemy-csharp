using UsandoCallerArgumentExpression;

Console.WriteLine("=== Gestão de Produtos (Versão Antiga) ===\n");

var service = new ProdutoService();

// Cenário 1: Sucesso
try
{
    service.AdicionarProduto("Notebook Gamer", 4500.00m);
}
catch (Exception ex)
{
    Console.WriteLine($" Erro: {ex.Message}");
}

// Cenário 2: Nome nulo
try
{
    service.AdicionarProduto(null!, 3000.00m);
}
catch (Exception ex)
{
    Console.WriteLine($" Erro: {ex.Message}");
}

// Cenário 3: Preço negativo
try
{
    service.AtualizarPreco(1, -50.00m);
}
catch (Exception ex)
{
    Console.WriteLine($" Erro: {ex.Message}");
}

// Cenário 4: ID inválido
try
{
    service.AtualizarPreco(0, 1500.00m);
}
catch (Exception ex)
{
    Console.WriteLine($" Erro: {ex.Message}");
}
Console.ReadKey();