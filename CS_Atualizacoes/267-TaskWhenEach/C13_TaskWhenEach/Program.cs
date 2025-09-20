
List<Task<int>> listaTarefas = 
    [
      SimulaOperacaoAsync(2000),
      SimulaOperacaoAsync(5000),
      SimulaOperacaoAsync(3000),
      SimulaOperacaoAsync(1000)
    ];

//var tarefas = await Task.WhenAll(listaTarefas);

await foreach (var tarefa in Task.WhenEach(listaTarefas))
    Console.WriteLine(await tarefa);

Console.ReadLine();

static async Task<int> SimulaOperacaoAsync(int delay)
{
    await Task.Delay(delay); // Simula um trabalho assíncrono
    return delay;
}
