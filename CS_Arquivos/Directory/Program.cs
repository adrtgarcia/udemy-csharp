Console.WriteLine("Classe Directory");

/*
 
    DIRECTORY E DIRECTORYINFO são usadas para manipular diretórios e ambas permitem a crição,
    exclusão, cópia, movimentação e renomeação de diretórios
 
    Directory: Classe estática que fornece métodos estáticos para trabalhar com diretórios
        - Métodos: CreateDirectory, Delete, Exists, GetCurrentDirectory, GetDirectories, GetFiles,
          GetCreationTime, GetParent, Move

 */

var caminhoDiretorio1 = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\auladiretorio";
var caminhoDiretorio2 = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\auladiretorio\teste";

try
{
    Console.WriteLine("\nCriando diretório");
    if (!Directory.Exists(caminhoDiretorio1))
    {
        Directory.CreateDirectory(caminhoDiretorio1);
        Console.WriteLine("\nDiretório criado");
    } 
    else
    {
        Console.WriteLine("\nO diretório já existe");
    }

    Console.WriteLine("\nCriando outro diretório");
    Directory.CreateDirectory(caminhoDiretorio2);
    Console.WriteLine("\nDiretório criado");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    Console.WriteLine("\nExcluindo diretório");
    if (Directory.Exists(caminhoDiretorio2))
    {
        Directory.Delete(caminhoDiretorio2);
        Console.WriteLine("\nDiretório excluído");
    }
    else
    {
        Console.WriteLine("\nDiretório excluído");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    Console.WriteLine("\nObtendo os subdiretórios");
    if (Directory.Exists(caminhoDiretorio1))
    {
        string[] subdiretorios = Directory.GetDirectories(caminhoDiretorio1);
        foreach (string sub in subdiretorios) Console.WriteLine(sub);
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
var caminhoDestino = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\newauladiretorio";
Directory.Move(caminhoDiretorio1, caminhoDestino);
