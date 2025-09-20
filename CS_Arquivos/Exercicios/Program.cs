using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Exercícios");

// EX01
Console.WriteLine("\nEX01\n");

/* Console.Write("\nDigite o caminho do arquivo: ");
string caminho = Console.ReadLine(); */

string caminho = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\poesia.txt";

if (File.Exists(caminho))
{
    FileInfo fileInfo = new FileInfo(caminho);
    Console.WriteLine($"O arquivo foi criado em {fileInfo.CreationTime}");
}
else
    Console.WriteLine("O arquivo não foi encontrado.");


// EX02
Console.WriteLine("\nEX02\n");

/* Console.Write("\nDigite o caminho do arquivo de origem: ");
string caminhoOrigem = Console.ReadLine();
Console.Write("\nDigite o caminho do diretório de destino: ");
string caminhoDestino = Console.ReadLine(); */

string caminhoOrigem = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\poesia.txt";
string caminhoDestino = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\copia";

string nomeArquivo = Path.GetFileName(caminhoOrigem);
string caminhoDestinoCompleto = Path.Combine(caminhoDestino, nomeArquivo);

File.Copy(caminhoOrigem, caminhoDestinoCompleto, true);
Console.WriteLine("Arquivo copiado com sucesso.");


// EX03
Console.WriteLine("\nEX03\n");

caminho = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\arq03.txt";

using (StreamWriter writer = File.CreateText(caminho))
{
    writer.WriteLine("Primeira linha de texto");
}

using (StreamWriter writer = File.AppendText(caminho))
{
    writer.WriteLine("Segunda linha de texto");
}

using (StreamReader reader = File.OpenText(caminho))
{
    string conteudoLido = reader.ReadToEnd();
    Console.WriteLine(conteudoLido);
}


// EX04
Console.WriteLine("\nEX04\n");

/* Console.Write("Digite o caminho do arquivo de origem: ");
caminhoOrigem = Console.ReadLine();
Console.Write("Digite o caminho do arquivo de destino: ");
caminhoDestino = Console.ReadLine(); */

caminhoOrigem = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\poesia.txt";
caminhoDestino = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\poesiaCrip.txt";

string chave = "MinhaChave123456";
byte[] chaveBytes = Encoding.UTF8.GetBytes(chave).Take(16).ToArray();

string conteudo = File.ReadAllText(caminhoOrigem);
byte[] conteudoCriptografado;

using (Aes aes = Aes.Create())
{
    aes.Key = Encoding.UTF8.GetBytes(chave);
    aes.Mode = CipherMode.CBC;
    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
    
    using (MemoryStream memoryStream = new())
    {
        using (CryptoStream cryptoStream = new(memoryStream, encryptor, CryptoStreamMode.Write))
        {
            using (StreamWriter writer = new(cryptoStream))
            {
                writer.Write(conteudo);
            }
            conteudoCriptografado = memoryStream.ToArray();
        }
    }
}

File.WriteAllBytes(caminhoDestino, conteudoCriptografado);
Console.WriteLine("Arquivo criptografado com sucesso.");


// EX05
Console.WriteLine("\nEX05\n");

/* Console.WriteLine("Digite o caminho do arquivo de imagem:");
string imagePath = Console.ReadLine();
Console.WriteLine("Digite o caminho do arquivo de destino:");
string textFilePath = Console.ReadLine(); */

string imagePath = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\breach.png";
string textFilePath = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\breachB64.txt";

byte[] imageBytes = File.ReadAllBytes(imagePath);
string base64String = Convert.ToBase64String(imageBytes);
File.WriteAllText(textFilePath, base64String);
Console.WriteLine("Arquivo de texto salvo com sucesso.");


// EX06
Console.WriteLine("\nEX06\n");

caminho = @"C:\Users\amand\OneDrive\Área de Trabalho\temp";
string[] arquivos = Directory.GetFiles(caminho);

foreach (string arquivo in arquivos)
    Console.WriteLine(Path.GetFileName(arquivo));


// EX07
Console.WriteLine("\nEX07\n");

caminho = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\copia";
DirectoryInfo diretorio = new(caminho);

foreach (var subdiretorio in diretorio.GetDirectories())
    Console.WriteLine(subdiretorio.Name);


// EX08
Console.WriteLine("\nEX08\n");

string novoDiretorio = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\novoDiretorio";
string novoArquivo = "novoArquivo.txt";

Directory.CreateDirectory(novoDiretorio);

caminho = Path.Combine(novoDiretorio, novoArquivo);
File.Create(caminho);

Console.WriteLine("Diretório e arquivo criados com sucesso.");


// EX09
Console.WriteLine("\nEX09\n");
caminhoOrigem = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\copia\poesia.txt";
caminhoDestino = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\novoDiretorio";

nomeArquivo = Path.GetFileName(caminhoOrigem);
caminhoDestinoCompleto = Path.Combine(caminhoDestino, nomeArquivo);
File.Copy(caminhoOrigem, caminhoDestinoCompleto);

Console.WriteLine("Arquivo copiado com sucesso.");


// EX10
Console.WriteLine("\nEX10\n");

caminhoOrigem = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\poesia.txt";
caminhoDestino = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\pasta";

nomeArquivo = Path.GetFileName(caminhoOrigem); 
caminhoDestinoCompleto = Path.Combine(caminhoDestino, nomeArquivo);

File.Move(caminhoOrigem, caminhoDestinoCompleto);

Console.WriteLine("Arquivo movido com sucesso");


// EX11
Console.WriteLine("\nEX11\n");

caminho = @"C:\Users\amand\OneDrive\Área de Trabalho\temp";
diretorio = new DirectoryInfo(caminho);

foreach (var arquivo in diretorio.GetFiles("*", SearchOption.AllDirectories))
{
    Console.WriteLine(arquivo.FullName);
}


// EX12
Console.WriteLine("\nEX12\n");

string caminhoDiretorio = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\novoDiretorio";
string caminhoArquivo = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\novoDiretorio\novoArquivo.txt";

File.Delete(caminhoArquivo);
Directory.Delete(caminhoDiretorio, true);

Console.WriteLine("\nDiretório e arquivo excluídos com sucesso.");


// EX13
Console.WriteLine("\nEX13\n");

caminhoArquivo = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\poesiaCrip.txt";
string novoNome = "cripPoesia.txt";
string caminhoCompleto = Path.Combine(Path.GetDirectoryName(caminhoArquivo), novoNome);

File.Move(caminhoArquivo, caminhoCompleto);

Console.WriteLine("Arquivo renomeado com sucesso.");


// EX14
Console.WriteLine("\nEX14\n");

caminhoDiretorio = @"C:\Users\amand\OneDrive\Área de Trabalho\temp";
long tamanhoTotal = GetDirectorySize(caminhoDiretorio);

Console.WriteLine($"Tamanho total do diretório: {tamanhoTotal} bytes");

static long GetDirectorySize(string diretorio)
{
    if (!Directory.Exists(diretorio))
        throw new DirectoryNotFoundException($"Diretório não encontrado.");
    
    long tamanhoTotal = 0;
    
    foreach (string arquivo in Directory.GetFiles(diretorio, "*", SearchOption.AllDirectories))
    {
        FileInfo info = new(arquivo);
        tamanhoTotal += info.Length;
    }

    return tamanhoTotal;
}


// EX15
Console.WriteLine("\nEX15\n");

caminhoDiretorio = @"C:\Users\amand\OneDrive\Área de Trabalho\temp";
DirectoryInfo dirInfo = new DirectoryInfo(caminhoDiretorio);

FileInfo[] todosArquivos = dirInfo.GetFiles();
DateTime ultimaModificacao = DateTime.MinValue;
string nomeArquivoMaisRecente = string.Empty;

foreach (FileInfo arquivo in todosArquivos)
{
    if (arquivo.LastWriteTime > ultimaModificacao)
    {
        ultimaModificacao = arquivo.LastWriteTime;
        nomeArquivoMaisRecente = arquivo.Name;
    }
}

if (!string.IsNullOrEmpty(nomeArquivoMaisRecente))
    Console.WriteLine($"O arquivo mais recente é: {Path.Combine(caminhoDiretorio, nomeArquivoMaisRecente)}");
else
    Console.WriteLine("Não foi encontrado nenhum arquivo.");
