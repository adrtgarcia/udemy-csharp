using Demo;
using System.Threading.Channels;

Console.WriteLine("--- Simulação de Processamento de Pedidos com Channels ---");

var channel = Channel.CreateUnbounded<int>();
// 1. Criando o Channel Bounded
//var channel = Channel.CreateBounded<int>(new BoundedChannelOptions(5)
//{
//    FullMode = BoundedChannelFullMode.Wait
//});

// CancellationToken para parar a produção após um tempo
var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));

// 2. Lançando os Produtores
var produtores = new List<Task>
{
    ProcessaPedidos.ProduzirPedidos(channel.Writer, 1, cts.Token),
    ProcessaPedidos.ProduzirPedidos(channel.Writer, 2, cts.Token)
};
Console.WriteLine("2 Produtores iniciados. Gerando pedidos...");

// 3. Lançando os Consumidores
var consumidores = new List<Task>
{
    ProcessaPedidos.ConsumirPedidos(channel.Reader, 1),
    ProcessaPedidos.ConsumirPedidos(channel.Reader, 2),
    ProcessaPedidos.ConsumirPedidos(channel.Reader, 3),
    ProcessaPedidos.ConsumirPedidos(channel.Reader, 4)
};
Console.WriteLine("4 Consumidores iniciados. Processando pedidos...");

// 4. Orquestração e Encerramento
await Task.Delay(Timeout.Infinite, cts.Token).ContinueWith(_ => { });

Console.WriteLine("\n--- TEMPO ESGOTADO! Parando de produzir novos pedidos. ---");
channel.Writer.Complete();

await Task.WhenAll(produtores);
await Task.WhenAll(consumidores);

Console.WriteLine("\n--- Processamento concluído. Todos os pedidos foram finalizados. ---");
Console.ReadKey();