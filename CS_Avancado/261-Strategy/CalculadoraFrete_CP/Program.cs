using CalculadoraDeFrete_CP;
using CalculadoraFrete_CP;

Console.WriteLine(" Usando o padrão Strategy \n");

var pedido1 = new Pedido { Valor = 150.0 };

var calculadora = new CalculadoraDeFrete(new FreteSedex());
double frete1 = calculadora.ExecutarCalculo(pedido1); // Saída: Calculando frete via Sedex...
Console.WriteLine($"Valor do frete: R$ {frete1}");

// Cliente mudou para PAC - troca estratégia
calculadora.DefinirEstrategia(new FretePac());
double frete2 = calculadora.ExecutarCalculo(pedido1); // Saída: Calculando frete via PAC...
Console.WriteLine($"Valor do frete: R$ {frete2}");


Console.ReadKey();