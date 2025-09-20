using System.Diagnostics;

namespace Cancelamento1;

internal class Program
{
    private static CancellationTokenSource cancelToken;
    static async Task Main(string[] args)
    {
        Console.WriteLine("Cancelamento de Tarefas");

        /*
         
            token de cancelamento é um objeto que serve de base para um modelo unificado de
            cancelamento cooperativo de operações assíncronas ou síncronas de longa duração em .NET

                CancellationTokenSource
                
                Bool isCanceled
                Callback[] callbacks
                WaitHandle handle
                int state;

         */

        /*
         
            CancellationTokenSource é um objeto que cria um token de cancelamento e também emite
            o pedido de cancelamento para todas as cópias desse token

            CancellationToken propaga a notificação de que as operações devem ser canceladas
                - os ouvintes monitoram o valor da propriedade IsCancellationRequested do token
                  por sondagem, retorno de chamada ou identificador de espera

            OperationCanceledException é uma exceção que é lançada em um thread após o cancelamento
            de uma operação que a tarefa na thread estava executando
         
         */

        /*
         
            implementação:
                (1) instancie um objeto CancellationTokenSource, que gerencia e envia notificação de
                    cancelamento aos tokens de cancelamento individuais
                (2) passe o token retornado pela propriedade CancellationTokenSource.Token para cada
                    tarefa ou thread que escuta o cancelamento
                (3) forneça um mecanismo para cada tarefa ou encadeamento para responder ao cancelamento
                (4) chame o método CancellationTokenSource.Cancel para fornecer uma notificação de 
                    cancelamento
         
         */

        var stopwatch = new Stopwatch();
        stopwatch.Start();

        try
        {
            cancelToken = new();
            cancelToken.Cancel();
            var resultado = await OperacaoLonga(100, cancelToken.Token);

            Console.WriteLine(resultado);
        }
        catch (Exception e)
        {
            Console.WriteLine("\nTarefa cancelada");
            Console.WriteLine($"Tempo expirado após {stopwatch.Elapsed}");
            Console.WriteLine(e.Message);
        }
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
