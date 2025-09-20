

var pedidos = PedidoService.ObterPedidos();

var resultado = pedidos.ApenasAprovados()
                       .ApenasClientesEspeciais()
                       .ComValorMinimo(200)
                       .OrdenadosPorValorDecrescente();

Console.WriteLine("\n=== Relatório de Faturamento ===\n");
Console.WriteLine("## Clientes especiais, aprovados com valor mínimo de R$ 200,00 ##\n");

Console.WriteLine("{0,-10} | {1,-10} | {2,-12} | {3,10}", "Cliente", "Tipo", "Status", "Total");
Console.WriteLine(new string('-', 50));

foreach (var pedido in resultado)
{
    Console.WriteLine("{0,-10} | {1,-10} | {2,-12} | {3,10:C}",
        pedido.Cliente,
        pedido.TipoCliente,
        pedido.Status,
        pedido.Total);
}
Console.ReadKey();
