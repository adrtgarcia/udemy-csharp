Console.WriteLine("Tratamento de Múltiplas Exceções");

/*
 
    se o método assíncrono criar várias Tasks ou usar o método Task.WhenAll, todas as
    exceções ocorridas serão capturadas em uma instância de AggregateException

    aguardar (await) a instância de Task, usando apenas try-catch, vai obter apenas a 
    primeira exceção, mesmo que várias possam ter sido lançadas
    
    como resolver?
        a classe AggregateException ( : Exception) contém uma propriedade chamada
        InnerExceptions, que é uma coleção de exceções que foram lançadas durante a 
        execução assíncrona

 */

await LancaMultExcAsync();

static async Task LancaMultExcAsync()
{
    Task? tarefas = null;
    try
    {
        var primeiraTask = Task.Run(() =>
        {
            Task.Delay(2000);
            throw new IndexOutOfRangeException("IndexOutOfRangeException lançada");
        });

        var segundaTask = Task.Run(() => {
            Task.Delay(3000);
            throw new InvalidOperationException("InvalidOperationException lançada");
        });

        tarefas = Task.WhenAll(primeiraTask, segundaTask);
        await tarefas;
    }
    catch
    {
        Console.WriteLine("\nExceções:");
        AggregateException allEx = tarefas.Exception;
        foreach (var ex in allEx.InnerExceptions)
        {
            Console.WriteLine(ex.GetType().ToString());
            Console.WriteLine(ex.Message);
        }
    }
}
