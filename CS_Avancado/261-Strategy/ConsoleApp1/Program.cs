using CalculadoraFrete_SP;

Console.WriteLine("--- Implementação sem Padrão de projeto ---\n");
var calculadora = new CalculadoraDeFrete();

// 2. Simular o primeiro pedido: um cliente que escolheu Sedex
Console.WriteLine("Cenário 1: Cliente escolhe Sedex");
var pedidoSedex = new Pedido { Valor = 250.00, TipoFrete = "sedex" };

// 3. Calcular e exibir o resultado
double freteSedex = calculadora.Calcular(pedidoSedex);
Console.WriteLine($"Valor do pedido: R$ {pedidoSedex.Valor:F2}");
Console.WriteLine($"Custo do frete: R$ {freteSedex:F2}");
Console.WriteLine("----------------------------------------------------\n");

// 4. Simular o segundo pedido: um cliente que escolheu PAC
Console.WriteLine("Cenário 2: Cliente escolhe PAC");
var pedidoPac = new Pedido { Valor = 250.00, TipoFrete = "pac" };

// 5. Calcular e exibir o resultado
double fretePac = calculadora.Calcular(pedidoPac);
Console.WriteLine($"Valor do pedido: R$ {pedidoPac.Valor:F2}");
Console.WriteLine($"Custo do frete: R$ {fretePac:F2}");
Console.WriteLine("----------------------------------------------------\n");

// 6. Simular um cenário de erro: tipo de frete inválido
Console.WriteLine("Cenário 3: Cliente informa um tipo de frete inválido");
var pedidoErro = new Pedido { Valor = 100.00, TipoFrete = "motoboy" };

// 7. Calcular e exibir o resultado
double freteErro = calculadora.Calcular(pedidoErro);
Console.WriteLine($"Valor do pedido: R$ {pedidoErro.Valor:F2}");
Console.WriteLine($"Custo do frete: R$ {freteErro:F2}");
Console.WriteLine("----------------------------------------------------\n");

Console.ReadKey();