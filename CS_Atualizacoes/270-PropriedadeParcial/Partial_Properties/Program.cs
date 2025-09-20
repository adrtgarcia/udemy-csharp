using Partial_Properties;

Produto produto = new();

produto.Id = 1;
produto.Nome = "Caderno";
produto.Preco = 10.00m;

Console.WriteLine($"O valor do produto com imposto é :" +
                  $" R$ {produto.ValorComImposto}");

Console.ReadLine();