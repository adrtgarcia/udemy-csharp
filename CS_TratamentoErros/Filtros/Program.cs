Console.WriteLine("Filtros de Exceções");

/*
 
    Exception Filters permite executar blocos try-catch com base em uma
    condição específica quando ocorre uma exceção
        - ou seja, quando há vários blocos catch, podemos decidir qual deverá
          ser executado segundo um critério pré-definido, especificando uma condição
          no bloco catch

    sintaxe:
        try 
        { ... }
        catch (Exception e) when (Filtro/Critério/Condição)
        { ... }
 
 */

try
{
    Console.WriteLine("\ninforme o dividendo:");
    int dividendo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\ninforme o divisor:");
    int divisor = Convert.ToInt32(Console.ReadLine());
    int resultado = dividendo / divisor;
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}");
}
catch (DivideByZeroException e) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
{
    Console.WriteLine("\nsexta-feira não capturamos estas exceções\n");
}
/*
catch (Exception e) when ((dividendo / divisor) == 0)
{
    // este bloco nunca será alcançado, pois a condição lança uma exceção
    // e a cláusula when será definida como false e será ignorada
    Console.WriteLine("esta linha nunca será printada");
}
*/
catch (Exception e) when (e.Message.Contains("format"))
{
    Console.WriteLine("\nformato errado");
    Console.WriteLine(e.StackTrace);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
