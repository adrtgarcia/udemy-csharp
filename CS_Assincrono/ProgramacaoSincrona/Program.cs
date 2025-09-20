Console.WriteLine("Programação Síncrona");

/*

    programação síncrona executa todas as tarefas em sequência, aguardando que a execução de cada 
    tarefa seja concluída antes de iniciar outra
  
 */

int espera = 4000;

Console.WriteLine("\nTecle algo para iniciar:");
Console.ReadLine();

RealizarTarefa(espera);

Console.WriteLine($"\nTempo gasto: {espera / 1000} segundos");
Console.WriteLine("\nFim do processamento");

static void RealizarTarefa(int tempo)
{
    Console.WriteLine("\nIniciando tarefa...");
    // Task.Delay(TimeSpan.FromSeconds(tempo));
    Thread.Sleep(tempo);
    Console.WriteLine("\nTarefa concluída");
}
