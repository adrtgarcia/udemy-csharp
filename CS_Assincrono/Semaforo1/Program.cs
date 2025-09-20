internal class Program
{
    public static Semaphore tPool = new(3, 5);
    static void Main(string[] args)
    {
        Console.WriteLine("Controlando threads com Semáforos");

        /*
 
        classe Semaphore:
            limite o número de threads que podem ter acessoa um recurso compartilhado de forma simultânea
            -> Semaphore semaforo = new(initialCount, maximumCount)
                    * onde initialCount é o número inicial de requests/entradas concedidas simultaneamente
                           maximumCount é o número máximo de requests/entradas concedidas simultaneamente

            métodos:
                - WaitOne() permite a entrada das threads no semáforo, incrementando a contagem
                - Release() chamado sempre que uma thread é finalizada, ou quando se quer liberar a thread 
                  para outra entrar, decrementando a contagem
 
        */

        Console.WriteLine("\nexemplo simples do funcionamento do semáforo\n");
        Semaphore s = new(1, 2);
        Console.WriteLine("\nincluindo thread...");
        s.WaitOne();
        Console.WriteLine("\nmétodo executado");
        s.Release();
        Console.WriteLine("\nthread liberada");


        Console.WriteLine("\n\n-- exemplo sem semaphore --\n\n");
        for (int i = 0; i < 10; i++)
        {
            Thread tObject = new(new ThreadStart(ProcessarOperacaoSS));
            tObject.Name = "Thread: " + i;
            tObject.Start();
        }

        Console.WriteLine("\n\n-- exemplo com semaphore --\n\n");
        for (int i = 0; i < 10; i++)
        {
            Thread tObject = new(new ThreadStart(ProcessarOperacaoCS));
            tObject.Name = "Thread: " + i;
            tObject.Start();
        }
    }
    static void ProcessarOperacaoSS()
    {
        Console.WriteLine($"\n{Thread.CurrentThread.Name} entrou na sessão crítica...");
        Thread.Sleep(5000);
        Console.WriteLine($"{Thread.CurrentThread.Name} foi liberada");
    }
    static void ProcessarOperacaoCS()
    {
        tPool.WaitOne();
        Console.WriteLine($"\n{Thread.CurrentThread.Name} entrou na sessão crítica...");
        Thread.Sleep(5000);
        tPool.Release();
        Console.WriteLine($"{Thread.CurrentThread.Name} foi liberada");
    }
}
