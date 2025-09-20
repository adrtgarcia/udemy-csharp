Console.WriteLine("Stream - Exercício");

string caminho = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\dados.txt";

while(true)
{
    Console.WriteLine("\nSelecione uma opção");
    Console.WriteLine("1 - Criar um arquivo");
    Console.WriteLine("2 - Gravar em arquivo");
    Console.WriteLine("3 - Ler arquivo");
    Console.WriteLine("4 - Procurar texto em arquivo");
    Console.WriteLine("0 - Sair");

    int opcao = Convert.ToInt32(Console.ReadLine());
    if (opcao == 0) break;
    
    switch (opcao)
    {
        case 1:
            CriarArquivo(caminho);
            break;
        case 2:
            GravarArquivo(caminho);
            break;
        case 3:
            LerArquivo(caminho);
            break;
        case 4:
            ProcurarTextoArquivo(caminho);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

static void CriarArquivo(string caminho)
{
    try
    {
        using (FileStream fs = new(caminho, FileMode.Create, FileAccess.Write));
        Console.WriteLine("\nArquivo criado");
        Console.WriteLine($"Caminho: {caminho}");
        Console.WriteLine();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

static void GravarArquivo(string caminho)
{
    Console.WriteLine("\nDigite o texto a ser gravado:");
    string texto = Console.ReadLine();

    try
    {
        using (StreamWriter writer = new(caminho, true))
        {
            writer.WriteLine(texto);
        }
        Console.WriteLine($"Texto agravado no arquivo");
        Console.WriteLine();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

static void LerArquivo(string caminho)
{
    if (!File.Exists(caminho))
    {
        Console.WriteLine("\nArquivo não encontrado");
        return;
    }

    Console.WriteLine("\nAcessando arquivo...\n");

    try
    {
        using (StreamReader reader = new(caminho))
        {
            string linha;
            while ((linha = reader.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

static void ProcurarTextoArquivo(string caminho)
{
    if (!File.Exists(caminho))
    {
        Console.WriteLine("\nArquivo não encontrado");
        return;
    }

    Console.WriteLine("\nDigite o texto a ser procurado:");
    string texto = Console.ReadLine();

    Console.WriteLine("\nAcessando arquivo...\n");

    try
    {
        bool encontrado = false;
        using (StreamReader reader = new(caminho))
        {
            string linha;
            int numLinha = 0;
            while ((linha = reader.ReadLine()) != null)
            {
                numLinha++;
                if (linha.Contains(texto))
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine($"\nO conteúdo foi encontrado na linha {numLinha} do arquivo");
                Console.WriteLine($"{numLinha}: {linha}");
            } 
            else
            {
                Console.WriteLine("\nO conteúdo não foi encontrado no arquivo");
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
