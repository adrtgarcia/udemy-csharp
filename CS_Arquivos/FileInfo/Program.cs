Console.WriteLine("Classe FileInfo");

/*

    FILEINFO existe no System.IO e é usada para obter informações detalhadas sobre um arquivo,
    como tamanho, nome, data de criação, data de modificação
        - permite também abrir, copiar, mover e excluir arquivos
        - requer uma instância da classe para realizar as operações
        - quando as propriedades são recuperadas pela primeira vez, o método Refresh() é chamado,
          e em chamadas subsequentes é necessário chamá-lo para obter a cópia mais recente das
          informações

    propriedades:
        - Directory, DirectoryName, Exists, IsReadOnly, Length, Name

    métodos:
        - CopyTo, Decrypt, Delete, Crypt, GetAccessControl, MoveTo, Replace, ToString, Open,
          OpenRead, OpenText, OpenWrite

    FileInfo x FileSystemInfo
        - FileInfo é usada para representar um arquivo
        - FileSystemInfo é a classe base para FileInfo e DirectoryInfo

 */

var caminhoOrigem = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\aulafile\poesia.txt";
var caminhoDestino = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\aulafile\txt\poesia.txt";
var caminhoCopia = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\aulafile\poesiacopia.txt";

FileInfo arquivoOrigem = new FileInfo(caminhoOrigem);

Console.WriteLine($"\nNome: {arquivoOrigem.Name}");
Console.WriteLine($"\nNome completo: {arquivoOrigem.FullName}");
Console.WriteLine($"\nSomente leitura: {arquivoOrigem.IsReadOnly}");
Console.WriteLine($"\nNome do diretório: {arquivoOrigem.Directory?.Name}");
Console.WriteLine($"\nTamanho do arquivo: {arquivoOrigem.Length} bytes");
Console.WriteLine($"\nÚltima modificação: {arquivoOrigem.LastWriteTime}");

if (arquivoOrigem.Exists)
{
    Console.WriteLine("\nCopiando para poesiacopia.txt");
    arquivoOrigem.CopyTo(caminhoCopia);
}
else
{
    Console.WriteLine("\nO arquivo poesia.txt não existe");
}

Console.WriteLine("\nMovendo poesia.txt para pasta txt");
arquivoOrigem.MoveTo(caminhoDestino);
