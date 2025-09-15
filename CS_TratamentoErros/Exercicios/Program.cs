using Exercicios;

Console.WriteLine("Exercícios - Tratamento de Erros");

/*
 EX01
    (V) Uma exceção é uma indicação de que ocorreu um erro durante a execução de um programa
    (V) A classe System.Exception é a classe base de todas as exceções em C#
    (V) A pilha de execução (stack trace) mostra a sequência de chamadas de métodos que levaram à exceção
    (V) As exceções em C# são organizadas em uma hierarquia de classes, com a classe System.Exception no topo da hierarquia
    (V) Todas as exceções em C# são subclasses da classe System.Exception
 */


/*
 EX02
    (V) O bloco try é usado para envolver o código que pode gerar uma exceção
    (V) O bloco catch é usado para capturar a exceção e lidar com ela de alguma forma
    (V) O bloco finally é opcional e é usado para executar código, independentemente de ter ocorrido ou não uma exceção
    (F) O bloco finally é sempre executado antes do bloco catch
    (V) É possível ter vários blocos catch para capturar diferentes tipos de exceções
 */


/* 
 EX03
    - ArgumentNullException é uma subclasse da ArgumentException, usada especificamente quando um argumento passado 
      para um método é null quando não deveria ser
    - ArgumentException é uma exceção mais genérica para qualquer tipo de erro no valor de um argumento que não 
      seja null 
 */

Console.WriteLine("\nEX03: Tratando entrada");

try
{
    Console.WriteLine("\nInforme o valor:");
    string valor = Console.ReadLine();

    if (valor == null)
        throw new ArgumentNullException("valor", "A entrada não pode ser nula");
    else if (string.IsNullOrWhiteSpace(valor))
        throw new ArgumentException("A entrada não pode estar vazia", "valor");

    Console.WriteLine($"\nValor informado: {valor}");
}
catch (ArgumentNullException e)
{
    Console.WriteLine($"ERRO: {e.Message}");
}
catch (ArgumentException e)
{
    Console.WriteLine($"ERRO: {e.Message}");
}
finally
{
    Console.WriteLine("\nFim do processamento\n");
}


// EX04
Console.WriteLine("\nEX04: Tratando nome e idade");

try
{
    Console.WriteLine("\nInforme sua idade:");
    int idade = Convert.ToInt32(Console.ReadLine());

    if (idade < 0)
        throw new ArgumentException("A idade não pode ser negativa");
    else if (idade == 0)
        throw new NotImplementedException("A idade ainda não foi definida");

    Console.WriteLine("\nInforme seu nome:");
    string nome = Console.ReadLine();

    if (string.IsNullOrEmpty(nome))
        throw new NullReferenceException("O nome não pode ser nulo nem vazio");

    Console.WriteLine($"\n{nome}, {idade} anos");
}
catch (ArgumentException e)
{
    Console.WriteLine($"ERRO DE ARGUMENTO: {e.Message}");
}
catch (NotImplementedException e)
{
    Console.WriteLine($"ERRO DE IMPLEMENTAÇÃO: {e.Message}");
}
catch (NullReferenceException e)
{
    Console.WriteLine($"ERRO DE REFERÊNCIA NULA: {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"ERRO INESPERADO: {e.Message}");
}
finally
{
    Console.WriteLine("\nFim do processamento\n");
}


// EX05
Console.WriteLine("\nEX05: Tratando índice");
int[] numeros = { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };

Console.WriteLine("\nImprimindo vetor de inteiros:");
foreach (int i in numeros) Console.Write(i + "  ");
Console.WriteLine();

try
{
    Console.WriteLine("\nInforme um índice para acessar o elemento:");
    int indice = Convert.ToInt32(Console.ReadLine());

    if (indice == null)
        throw new ArgumentNullException("O índice não pode ser null");
    else if ((indice < 0) || (indice > numeros.Length))
        throw new IndexOutOfRangeException("O índice não pode ultrapassar os limites do vetor");

    Console.WriteLine($"\nAcessando índice {indice}");
    Console.WriteLine($"numeros[{indice}] = {numeros[indice]}");
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine($"ERRO: {e.Message}");
}
catch (ArgumentNullException e)
{
    Console.WriteLine($"ERRO: {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"ERRO: {e.Message}");
}
finally
{
    Console.WriteLine("\nFim do processamento\n");
}


// EX06
Console.WriteLine("\nEX06: Tratando saldo");

try
{
    // int saldo = 0;
    Console.WriteLine("\nInforme o valor do saldo:");
    int saldo = Convert.ToInt32(Console.ReadLine());

    // int valorSaque = 100;
    Console.WriteLine("\nInforme o valor do saque:");
    int valorSaque = Convert.ToInt32(Console.ReadLine());

    if (valorSaque > saldo)
        throw new SaldoInsuficienteException("O saldo é insuficiente para este saque");
    
    saldo -= valorSaque;

    Console.WriteLine("\nSaque efetuado com sucesso");
    Console.WriteLine($"Novo saldo: {saldo.ToString("c")}");
}
catch (SaldoInsuficienteException e)
{
    Console.WriteLine($"\nERRO: {e.Message}");
}
finally
{
    Console.WriteLine("\nFim do processamento\n");
}


/*
 EX07
    A execução do método MeuMetodo() com valor = -5 resulta na mensagem "Erro: Valor negativo não permitido" 
    sendo exibida na tela. 
 */
Console.WriteLine("EX07: MeuMetodo(-5)");

Console.WriteLine("Chamando o método MeuMetodo() com valor = -5...");
MeuMetodo(-5);

static void MeuMetodo(int valor)
{
    try
    {
        if (valor < 0)
            throw new MinhaException("Valor negativo não permitido");
        else if (valor > 100)
            throw new ArgumentException("O valor não pode ser maior que 100");
        Console.WriteLine("O valor é válido");
    }
    catch (MinhaException e) when (valor < 0)
    {
        Console.WriteLine($"\nERRO: {e.Message}");
    }
    catch (ArgumentException e) when (valor > 100)
    {
        Console.WriteLine($"\nERRO: {e.Message}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"\nERRO GENÉRICO: {e.Message}");
    }
    finally
    {
        Console.WriteLine("\nMétodo concluído\n");
    }
}

public class MinhaException : Exception
{
    public MinhaException() { }
    public MinhaException(string? message) : base(message) { }
}
