Console.WriteLine("Streams");

/*  LIBERANDO RECURSOS (CLOSE OU USING)

using (FileStream fs = new FileStream(caminho, FileMode.Open))
{
    ...
}

 */

string path = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\poesia.txt";

try
{
    /* VERSÃO TRADICIONAL

    using(FileStream fs = new(path, FileMode.Open, FileAccess.Read))
    {
        using(StreamReader leitor = new(fs))
        {
            string? linha;
            while ((linha = leitor.ReadLine()) != null) 
                Console.WriteLine(linha);
        }
    }
    
     */

    /* VERSÃO DECLARATIVA
    
    using FileStream fs = new(path, FileMode.Open, FileAccess.Read);
    using StreamReader leitor = new(fs);
    string? linha;
    while ((linha = leitor.ReadLine()) != null) 
        Console.WriteLine(linha);
    
     */
    
    using StreamReader leitor = File.OpenText(path);
    string? linha;
    while ((linha = leitor.ReadLine()) != null) 
        Console.WriteLine(linha);
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("\nPrograma encerrado");
}
