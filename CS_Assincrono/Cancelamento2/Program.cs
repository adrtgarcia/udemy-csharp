using System.Diagnostics;

namespace Cancelamento2;

internal class Program
{
    // private static CancellationTokenSource cancelToken;
    static async Task Main(string[] args)
    {
        Console.WriteLine("Cancelamento de Tarefas");

        var stopwatch = new Stopwatch();
        stopwatch.Start();

        try
        {
            // cancelToken = new();
            // cancelToken.Cancel();
            // var resultado = await OperacaoLonga(100, cancelToken.Token);
            // Console.WriteLine(resultado);

            Console.WriteLine("\nCancelamento automático após 1,5s");
            await ExecutaAsync(1500);
        }
        catch (Exception e)
        {
            Console.WriteLine("\nTarefa cancelada");
            Console.WriteLine($"Tempo expirado após {stopwatch.Elapsed}");
            Console.WriteLine(e.Message);
        }
    }
    public static async Task ExecutaAsync(int tempo)
    {
        using (var cToken = new CancellationTokenSource(tempo))
        {
            try
            {
                var resultado = await OperacaoLonga(100, cToken.Token);
                Console.WriteLine($"resultado = {resultado}");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* ou ainda...
         
            using (var cToken = new CancellationTokenSource())
            {
                cToken.CancelAfter(tempo);
                try
                {
                    var resultado = await OperacaoLonga(100, cToken.Token);
                    Console.WriteLine($"resultado = {resultado}");
                }
                catch (Exception)
                {
                    throw;
                }
            }
         
         */

        /* cancelamento manual... 
            
            using (var cToken = new CancellationTokenSource())
            {
                var tecladoTask = Task.Run(() => 
                {
                    Console.WriteLine("Pressione algo para cancelar:");
                    Console.ReadKey();
                    cToken.Cancel();
                });
                try
                {
                    var resultado = await OperacaoLonga(100, cToken.Token);
                    Console.WriteLine($"resultado = {resultado}");
                }
                catch (Exception)
                {
                    throw;
                }
            }

         */
    }
    private static Task<int> OperacaoLonga(int valor, CancellationToken token = default)
    {
        Task<int>? task = null;
        task = Task.Run(() =>
        {
            int resultado = 0;
            for (int i = 0; i < valor; i++)
            {
                if (token.IsCancellationRequested)
                    throw new TaskCanceledException(task);

                Thread.Sleep(2000);
                resultado += i;
            }
            return resultado;
        });
        return task;
    }
}
