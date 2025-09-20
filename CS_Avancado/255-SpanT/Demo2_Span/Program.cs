using System.Diagnostics;
using System.Text;

Console.WriteLine("Método Avançado (usando Span)\n");

// Dados de uma venda (simulando um registro de banco de dados ou arquivo)
string saleRecord = "42|2024-03-15|299.99|PlayStation 5";

Stopwatch sw = Stopwatch.StartNew();

// Processamento PROFISSIONAL (zero alocações!)
for (int i = 0; i < 100_000; i++)
{
    ReadOnlySpan<char> recordSpan = saleRecord.AsSpan();

    // Extrai o ID (42)
    int pipePos = recordSpan.IndexOf('|');
    int id = int.Parse(recordSpan.Slice(0, pipePos));

    // Extrai a Data (2024-03-15)
    ReadOnlySpan<char> remaining = recordSpan.Slice(pipePos + 1);
    pipePos = remaining.IndexOf('|');
    DateTime date = DateTime.Parse(remaining.Slice(0, pipePos));

    // Extrai o Preço (299.99)
    remaining = remaining.Slice(pipePos + 1);
    pipePos = remaining.IndexOf('|');
    double price = double.Parse(remaining.Slice(0, pipePos));

    // Extrai o Nome do Produto (já é o final)
    string product = remaining.Slice(pipePos + 1).ToString(); // Só aloca aqui!
}

sw.Stop();
Console.WriteLine($"🟢 Método com Span<T>: {sw.ElapsedMilliseconds}ms");
Console.ReadKey();