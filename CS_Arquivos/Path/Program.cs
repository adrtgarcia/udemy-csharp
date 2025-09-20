Console.WriteLine("Classe Path");

/*
    
    PATH está presente no System.IO e executa operações em instâncias de String que contêm
    informações do caminho de um arquivo/diretório
        - fornece métodos e propriedades úteis para manipular caminhos de uma forma que é 
          compatível com o SO no qual o código está sendo executado
 
    campos: 
        - DirectorySeparatorChar, AltDirectorySeparatorChar, PathSeparator, VolumeSeparatorChar
 
 */

string caminho = "C:\\Users\\amand\\OneDrive\\Área de Trabalho\\temp";
string caminhorel = "txt\\teste.txt";

char dirSeparator = Path.DirectorySeparatorChar;
Console.WriteLine($"\nSeparador padrão: {dirSeparator}");

string[] diretorios = caminho.Split(dirSeparator);
Console.WriteLine($"\nDiretórios e arquivos:");
foreach (string dir in diretorios) Console.WriteLine(dir);

Console.WriteLine("\nCombinando caminhos");
string pathCombinado = Path.Combine(caminho, caminhorel);
Console.WriteLine(pathCombinado);

Console.WriteLine($"\nNome: {Path.GetDirectoryName(pathCombinado)}");
Console.WriteLine($"\nExtensão: {Path.GetExtension(pathCombinado)}");
Console.WriteLine($"\nNome do arquivo: {Path.GetFileName(pathCombinado)}");
Console.WriteLine($"\nNome do arquivo sem extensão: {Path.GetFileNameWithoutExtension(pathCombinado)}");
Console.WriteLine($"\nPossui extensão? {Path.HasExtension(pathCombinado)}");
Console.WriteLine($"\nContém raiz? {Path.IsPathRooted(pathCombinado)}");
Console.WriteLine($"\nNova extensão do arquivo: {Path.ChangeExtension(pathCombinado, ".docx")}");
Console.WriteLine($"\nRaiz? {Path.GetPathRoot(pathCombinado)}");

Console.WriteLine($"\nNome arquivo aleatório: {Path.GetRandomFileName()}");
Console.WriteLine($"\nNome arquivo temporário: {Path.GetTempFileName()}");
Console.WriteLine($"\nCaminho temporário: {Path.GetTempPath()}");

char[] charInvalido = Path.GetInvalidFileNameChars();
Console.WriteLine($"\nCaracteres inválidos em nome de arquivo: {new string(charInvalido)}");
