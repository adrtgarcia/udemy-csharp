using System.Threading.Channels;
namespace Demo;
public static class ProcessaPedidos
{
    // 2. Lógica do Produtor
    public static async Task ProduzirPedidos(ChannelWriter<int> writer, 
                                             int produtorId, 
                                             CancellationToken cancellationToken)
    {
        int pedidoId = produtorId * 1000; // Apenas para diferenciar os pedidos
        try
        {
            while (await writer.WaitToWriteAsync(cancellationToken))
            {
                // Aqui, verificamos se o canal está cheio para mostrar log
                if (!writer.TryWrite(pedidoId))
                {
                    Console.WriteLine($"[Produtor {produtorId}] ### Canal cheio ### Aguardando espaço...");
                    await Task.Delay(50, cancellationToken); // pequeno delay para não encher o log
                    continue; // tenta de novo na próxima iteração
                }

                Console.WriteLine($"[Produtor {produtorId}] Gerou o Pedido #{pedidoId}");
                pedidoId++;

                // Simula tempo de chegada de pedidos
                await Task.Delay(TimeSpan.FromMilliseconds(150), cancellationToken);
            }
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine($"[Produtor {produtorId}] cancelado.");
        }
    }

    // 3. Lógica do Consumidor
    public static async Task ConsumirPedidos(ChannelReader<int> reader, 
                                             int consumidorId)
    {
        Console.WriteLine($"[Consumidor {consumidorId}] pronto para processar.");

        //IAsyncEnumerable a melhor forma de consumir
        //todos os itens até o canal ser fechado
        await foreach (var pedidoId in reader.ReadAllAsync())
        {
            Console.WriteLine($"  -> [Consumidor {consumidorId}] Iniciando processamento do Pedido #{pedidoId}");

            // Simula um trabalho mais pesado
            await Task.Delay(TimeSpan.FromMilliseconds(1000));

            Console.WriteLine($"      => [Consumidor {consumidorId}] Pedido #{pedidoId} FINALIZADO.");
        }
        Console.WriteLine($"[Consumidor {consumidorId}] Finalizou.");
    }
}