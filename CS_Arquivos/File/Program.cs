Console.WriteLine("Classe File");

/*

    FILE está no System.IO e é usada para operações de leitura e gravação de arquivos,
    fornecendo métodos estáticos para criar, copiar, excluir, mover e abrir arquivos,
    além de métodos para criar, excluir e mover diretórios
 
    - Métodos de criação e manipulação de arquivos:
        Create, Delete, Exists, Copy, Move
    - Métodos para leitura e escrita de arquivos:
        ReadAllText, ReadAllBytes, WriteAllText, WriteAllBytes, AppendAllText
    - Outros métodos:
        ReadAllLines, GetLastWriteTime, GetLastAccessTime

 */

string caminho = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\arquivo.txt";

File.Create(caminho).Close();

string texto = "testando WriteAllText() no arquivo criado";
File.WriteAllText(caminho, texto);

File.AppendAllText(caminho, "Fernando Pessoa");
File.AppendAllText(caminho, "O poeta é um fingidor,\nFinge tão completamente\nQue chega a fingir que é dor\nA dor que deveras sente.");

string conteudo = File.ReadAllText(caminho);
Console.WriteLine("\nImprimindo conteúdo:\n");
Console.WriteLine(conteudo);

Console.WriteLine($"Última modificação: {File.GetLastWriteTime(caminho)}");
Console.WriteLine($"Último acesso: {File.GetLastAccessTime(caminho)}");

Console.WriteLine("\nImprimindo conteúdo:\n");
string[] linhas = File.ReadAllLines(caminho);
foreach (var linha in linhas) Console.WriteLine(linha);

string caminhoCopia = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\copia.txt";
Console.WriteLine($"Copiando de arquivo.txt para copia.txt");
File.Copy(caminho, caminhoCopia);   // não é possível copiar para um arquivo que já existe

conteudo = File.ReadAllText(caminhoCopia);
Console.WriteLine("\nImprimindo conteúdo:\n");
Console.WriteLine(conteudo);

string caminhoPasta = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\pasta\arquivo.txt";
Console.WriteLine($"Movendo arquivo.txt para pasta");
File.Move(caminho, caminhoPasta);

Console.WriteLine("\nExcluindo copia.txt");
File.Delete(caminhoCopia);
