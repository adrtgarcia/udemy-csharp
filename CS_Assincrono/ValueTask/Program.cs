Console.WriteLine("Programação Assíncrona - ValueTask e ValueTask<T>");

/*

    programação assíncrona é um modelo que permite que o aplicativo execute várias tarefas ao mesmo
    tempo sem bloquear a thread principal
        - async/wait
        - biblioteca: TPL (task parallel library)

        características:
            - inicia uma tarefa e continua a executar outras enquanto a primeira está em andamento
            - quando a tarefa secundária é concluída, o controle é transferido de volta para a primária
            - a thread principal do programa não é bloqueada
            - async indica que um método pode ser executado de forma assíncrona
            - await é usado para esperar a conclusão de uma tarefa assíncrona

    programação paralela é um modelo que permite que o aplicativo execute várias tarefas ao mesmo
    tempo, aproveitando os recursos do processador
        - biblioteca: parallel
 
 */

/*
 
    - VALUETASK fornece um resultado esperado de uma operação assíncrona
    - VALUETASK<T> fornece um tipo de valor que encapsula um Task<T> e um T
        
 */

/*

    Task e Task<T> são alocados na heap e usam garbage collector, ValueTask e ValueTask<T> 
    são alocados na stack e evitam alocações desnecessárias, melhorando o desempenho
 
        quando usar? 
            (1) resultado da operação executada pelo método assíncrono já está disponível no momento da espera
            (2) cenários assíncronos onde o armazenamento em buffer está presente
            (3) resultado da operação for concluída de forma síncrona
             
 */

Console.WriteLine("\nIniciando operação assíncrona...");

await Metodo1Async();
var retorno = await Metodo2Async(50);
Console.WriteLine($"\nretorno = {retorno}");

Console.WriteLine("\nOperação encerrada\n");

Console.WriteLine("\nInforme valor a:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme valor b:");
int b = Convert.ToInt32(Console.ReadLine());

/* var soma = await CalcularSoma(a, b);        usando Task */
var soma = CalcularSoma(a, b).Result;       /* usando ValueTask */
Console.WriteLine($"{a} + {b} = {a + b}");

static async ValueTask Metodo1Async()
{
    Console.WriteLine("\nMétodo sem retorno");
    await Task.Delay(3000);
}
static async ValueTask<int> Metodo2Async(int valor)
{
    Console.WriteLine("\nMétodo com retorno int");
    await Task.Delay(3000);
    return valor * 2;
}
static async ValueTask<int> CalcularSoma(int a, int b)
{
    if ((a == 0) && (b == 0)) return 0; /* se for Task, vai repetir sempre, 
                                           se for ValueTask, executa 1 vez */
    return await Task.Run(() => a + b);
}
