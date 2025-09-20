Console.WriteLine("Streams");

/*
 
    STREAM é uma classe abstrata para transferência de bytes de diferentes origens, e é a classe
    base para todas as outras classes que leem/escrever bytes em fontes diferentes

    FileStream
        - fornece um stream para um arquivo, dando suporte a operações de leitura e gravação
          síncronas e assíncronas
        - pode ser usada para ler, gravar, abrir e fechar arquivos, além de tratar manipuladores
          do SO (pipes, entrada padrão, saída padrão)
        - propriedades: CanRead, CanSeek, IsAsync, CanWrite, Length, Position, Name
 
    StreamReader (Helper Class)
        - fornece métodos para ler strings em um FileStream covertendo bytes em strings
    
    StreamWriter (Helper Class)
        - fornece métodos para gravar strings em um FileStream convertendo strings em bytes
 
 */

/*  CONSTRUTORES

string caminho = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\arq.txt";

// FileStream
FileStream fs1 = new(caminho, FileMode.Open, FileAccess.Read, FileShare.Read);

// File
FileStream fs2 = File.Open(caminho, FileMode.Open, FileAccess.Read, FileShare.Read);

// FileInfo
FileInfo fInfo = new(caminho);
FileStream fs3 = fInfo.Open(FileMode.Open, FileAccess.Read, FileShare.Read);

 */

/*  LIBERANDO RECURSOS (CLOSE OU USING)

using (FileStream fs = new FileStream(caminho, FileMode.Open))
{
    ...
}

 */

// EXERCÍCIO: 

string path = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\poesia.txt";
FileStream fs = null;
StreamReader leitor = null;

try
{
    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
    leitor = new StreamReader(fs);

    /*
        versão alternativa:
            leitor = File.OpenText(path);
        
        assim, não é necessário declarar FileStream fs
     */

    string? linha;
    while((linha = leitor.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }

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
    if (leitor != null) leitor.Close();
    if (fs != null) fs.Close();
    Console.WriteLine("\nPrograma encerrado");
}
