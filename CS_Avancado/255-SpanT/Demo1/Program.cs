using System.Diagnostics;

Console.WriteLine("Método Tradicional (usando Split e Parse)\n");

// Dados de uma venda (simulando um registro de banco de dados ou arquivo)
string linhaItem = "42|2024-03-15|299.99|PlayStation 5";

Stopwatch sw = Stopwatch.StartNew();

// Processamento INEFICIENTE (aloca strings a cada operação)
for (int i = 0; i < 100_000; i++) // Simula 100 mil transações
{
    string[] fields = linhaItem.Split('|');    // Aloca 4 strings!
    int id = int.Parse(fields[0]);             // Conversão lenta
    DateTime data = DateTime.Parse(fields[1]); // Mais alocação
    double preco = double.Parse(fields[2]);    // Outra alocação
    string produto = fields[3];                // Já alocado pelo Split
}
sw.Stop();

Console.WriteLine($"Tempo Gasto: {sw.ElapsedMilliseconds}ms");

Console.WriteLine("\nMétodo Avançado (usando Span<T>)\n");
Console.WriteLine("Para iniciar o processamento tecle algo...\n");
Console.ReadKey();

sw.Restart();

for (int i = 0; i < 100_000; i++)
{
    ReadOnlySpan<char> registroSpan = linhaItem.AsSpan();

    int posicaoPipe = registroSpan.IndexOf('|');

    int id = int.Parse(registroSpan.Slice(0, posicaoPipe));

    ReadOnlySpan<char> parteRestante = registroSpan.Slice(posicaoPipe + 1);

    posicaoPipe = parteRestante.IndexOf('|');

    DateTime data = DateTime.Parse(parteRestante.Slice(0, posicaoPipe));

    parteRestante = parteRestante.Slice(posicaoPipe + 1);
    posicaoPipe = parteRestante.IndexOf('|');
    double preco = double.Parse(parteRestante.Slice(0, posicaoPipe));

    string produto = parteRestante.Slice(posicaoPipe + 1).ToString();
}
sw.Stop();

Console.WriteLine($"Tempo gasto : {sw.ElapsedMilliseconds}ms");

Console.ReadKey();


