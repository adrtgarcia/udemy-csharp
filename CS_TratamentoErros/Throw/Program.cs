Console.WriteLine("Lançando exceções - Throw");

/*

    uma exceção pode ser lançada explicitamente usando a instrução THROW seguida por uma instância
    de uma classe de exceção, como Exception ou suas derivadas

    principais classes:
        - Exception (classe mãe)
        - NotImplementedException (método não implementado)
        - ArgumentException (argumento não corresponde ao parâmetro)
        - NullReferenceException (referência nula)
        - FormatException (formatação inválida)
        - IndexOutOfRangeException (índice fora do intervalo)
        - OverFlowException (excedeu a capacidade de processamento)
        - FileNotFoundException (arquivo não localizado)
        - InvalidCastException (não foi possível fazer a conversão)
        - StackOverFlowException (capacidade da pilha excedida)

 */

try
{
    Console.WriteLine("\nchamando o método ProcessarA");
    A.ProcessarA();
}
catch (Exception e)
{

    Console.WriteLine("\ntratando o erro na main");
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}

class A 
{ 
    public static void ProcessarA() 
    {
        try
        {
            B.ProcessarB();
        }
        catch (Exception e)
        {
            // throw e;     <- dar preferência ao throw
            Console.WriteLine("\ntratando o erro em A");
            Console.WriteLine("mandando erro para main");
            // throw;
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
            throw;
        } 
    } 
}
class B 
{ 
    public static void ProcessarB() 
    { 
        try
        {
            C.ProcessarC();
        }
        catch (Exception e)
        {
            // throw e;     <- dar preferência ao throw
            Console.WriteLine("\ntratando o erro em B");
            Console.WriteLine("mandando erro para A");
            // throw;
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
            throw;
        }
    }
} 
class C 
{ 
    public static void ProcessarC() 
    { 
        throw new NotImplementedException("método ProcessarC não implementado");
    } 
}
