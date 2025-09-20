Console.WriteLine("Streams Assíncronos");

var meses = new List<string>() { "janeiro", "fevereiro", "março", "abril" };

foreach (var mes in meses)
    Console.WriteLine(mes);
Console.WriteLine();

await foreach (var mes in GeraMeses()) /* <- precisa adicionar await */
    Console.WriteLine(mes);
Console.WriteLine();

// static async Task<IEnumerable<string>> GeraMeses()   <- assim não funciona, não itera
static async IAsyncEnumerable<string> GeraMeses()
{
    /* yield implementa um iterador e gera os valores um a um */
    yield return "maio";
    yield return "junho";

    await Task.Delay(2000);

    yield return "julho";
    yield return "agosto";
}
