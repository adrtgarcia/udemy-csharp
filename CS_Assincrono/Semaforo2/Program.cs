internal class Program
{
    private static SemaphoreSlim sSlim = new(4);
    static void Main(string[] args)
    {
        Console.WriteLine("Controlando threads com Semáforos");

        /*
         
            SemaphoreSlim é usada quando temos um número limitada de recursos e queremos limitar o número de threads que podem
            usar o recurso de forma simultânea com a segurança da thread

                SemaphoreSlim semaforo = new(int initialCount)
         
         */

        for (int i = 1; i <= 6; i++)
        {
            string tName = "Thread " + i;
            int espera = 2 + 2 * 1;
            var t = new Thread(() => AcessarBancoDados(tName, espera));

            t.Start();
        }
    }
    public static void AcessarBancoDados(string nome, int seconds)
    {
        Console.WriteLine($"{nome} aguardando acesso ao banco de dados...");
        sSlim.Wait();

        Console.WriteLine($"{nome} autorizada a acessar o banco de dados");
        Thread.Sleep(TimeSpan.FromSeconds(seconds));

        Console.WriteLine($"{nome} concluída");
        sSlim.Release();
    }
}
