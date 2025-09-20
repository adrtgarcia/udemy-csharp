Console.WriteLine("Programação Assíncrona - Task e Task<T>");

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
 
    TASK é um tipo de retorno padrão para um método assíncrono que não retorna nenhum valor
        - retorna uma tarefa que representa a operação assíncrona que será executada em segundo plano
        - o método pode ser marcado como async e pode conter um await para aguardar a conclusão da tarefa

    await MeuMetodo1Async();
    public async Task MeuMetodo1Async()
    {
        await Task.Delay(5000);
        Console.WriteLine("\nOperação assíncrona concluída");
    }

 */

/*

    TASK<T> é o tipo de retorno para um método assíncrono que retorna um valor T

    var resultado = await MeuMetodo2Async();
    public async Task<int> MeuMetodo2Async()
    {
        await Task.Delay(4000);
        Console.WriteLine("\nOperação assíncrona concluída");
        return 0;
    }

 */

Console.WriteLine("\nCafé da manhã síncrono\n");
CafeDaManha();

Console.WriteLine("\nCafé da manhã assíncrono\n");
await CafeDaManhaSync();

static void CafeDaManha()
{
    Console.WriteLine("\nPreparar o café");
    var cafe = PrepararCafe();

    Console.WriteLine("\nPreparar o pão");
    var pao = PrepararPao();

    ServirCafe(cafe, pao);
}
static void ServirCafe(Cafe cafe, Pao pao)
{
    Console.WriteLine("\nServindo café da manhã...");
    Thread.Sleep(3000);
    Console.WriteLine("\nCafé servido");
}
static Cafe PrepararCafe()
{
    Console.WriteLine("\nFervendo água...");
    Thread.Sleep(4000);
    Console.WriteLine("\nCoando café...");
    Thread.Sleep(2000);
    Console.WriteLine("\nAdoçando café...");
    return new Cafe();
}
static Pao PrepararPao()
{
    Console.WriteLine("\nPartindo pão...");
    Thread.Sleep(2000);
    Console.WriteLine("\nPassando manteiga...");
    Thread.Sleep(2000);
    Console.WriteLine("\nTostando pão...");
    return new Pao();
}
static async Task CafeDaManhaSync()
{
    Console.WriteLine("\nPreparar o café");
    var tCafe = PrepararCafeAsync();

    Console.WriteLine("\nPreparar o pão");
    var tPao = PrepararPaoAsync();

    var cafe = await tCafe;
    var pao = await tPao;

    ServirCafe(cafe, pao);
}
static async Task<Cafe> PrepararCafeAsync()
{
    Console.WriteLine("\nFervendo água...");
    await Task.Delay(4000);
    Console.WriteLine("\nCoando café...");
    await Task.Delay(2000);
    Console.WriteLine("\nAdoçando café...");
    return new Cafe();
}
static async Task<Pao> PrepararPaoAsync()
{
    Console.WriteLine("\nPartindo pão...");
    await Task.Delay(2500);
    Console.WriteLine("\nPassando manteiga...");
    await Task.Delay(2000);
    Console.WriteLine("\nTostando pão...");
    return new Pao();
}

public class Cafe() { }
public class Pao() { }
