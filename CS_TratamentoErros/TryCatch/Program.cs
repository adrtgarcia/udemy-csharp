Console.WriteLine("Bloco Try-Catch-Finally");

try
{
    Console.WriteLine("\ninforme o dividendo:");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\ninforme o divisor:");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = (dividendo / divisor);
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}");

    /*
        erros possíveis:
            - OverflowException
            - DivideByZeroException
            - FormatException     
     */

}
catch (FormatException)
{
    Console.WriteLine("\ninforme um valor inteiro");
}
catch (OverflowException)
{
    Console.WriteLine("\ninforme um valor inteiro entre 1 e 999999");
}
catch (DivideByZeroException)
{
    Console.WriteLine("\ninforme um divisor diferente de 0");
}
catch (Exception e)
{
    /*
        class Exception :
            - Message fornece detalhes da exceção
            - StackTrace contém um rastreamento de pilha que pode ser usado para determinar onde ocorreu o erro
            - InnerException pode ser usada para criar e preservar uma série de exceções durante o tratamento
            - Source obtém ou define o nome do aplicativo/objeto que causou o erro
            - HelpLink pode conter url/urn para um arquivo de ajuda que fornece informações abrangentes sobre a causa da uma exceção
     */

    Console.WriteLine($"\nMessage: {e.Message}");
    Console.WriteLine($"\nStackTrace: {e.StackTrace}");
    Console.WriteLine($"\nInnerException: {e.InnerException}");
    Console.WriteLine($"\nSource: {e.Source}");
    Console.WriteLine($"\nHelpLink: {e.HelpLink}");
}
finally
{
    Console.WriteLine("\noperação encerrada");
}