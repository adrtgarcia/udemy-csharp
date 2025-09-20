Console.WriteLine("Classe DirectoryInfo");

/*
 
    DIRECTORY E DIRECTORYINFO são usadas para manipular diretórios e ambas permitem a crição,
    exclusão, cópia, movimentação e renomeação de diretórios
     
    DirectoryInfo: Classe não estática que representa um diretório em uma instância de objeto
        - Propriedades: Exists, Name, Parent, Root
        - Métodos: Create, CreateSubDirectory, Delete, GetDirectories, GetFiles, MoveTo

 */

var caminhoDiretorio1 = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\auladiretorio";
var caminhoDiretorio2 = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\auladiretorio\teste";

DirectoryInfo dir = new(caminhoDiretorio1);

Console.WriteLine($"\nExists: {dir.Exists}");
Console.WriteLine($"\nName: {dir.Name}");
Console.WriteLine($"\nParent: {dir.Parent}");
Console.WriteLine($"\nRoot: {dir.Root}");

try
{
    Console.WriteLine("\nCriando diretório");
    if (!dir.Exists)
    {
        dir.Create();
        Console.WriteLine("\nDiretório criado");
        dir.CreateSubdirectory(caminhoDiretorio2);
    }
    else
    {
        Console.WriteLine("\nO diretório já existe");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    Console.WriteLine("\nObtendo os subdiretórios");
    if (dir.Exists)
    {
        var subdiretorios = dir.GetDirectories();
        foreach (var sub in subdiretorios) Console.WriteLine(sub.Name);
    }
    else
    {
        Console.WriteLine("\nO diretório não existe");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("\nMovendo diretório auladiretorio");
var caminhoDestino = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\novapasta";
Directory.Move(caminhoDiretorio1, caminhoDestino);

try
{
    Console.WriteLine("\nExcluindo diretório");
    if (dir.Exists)
    {
        dir.Delete();
        Console.WriteLine("\nDiretório excluído");
    }
    else
    {
        Console.WriteLine("\nDiretório não existe");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
