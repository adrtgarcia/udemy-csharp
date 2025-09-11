Console.WriteLine("Bloco Try-Catch");

while(true)
{
    Console.WriteLine("\nvalor de x:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("valor de y:");
    int y = Convert.ToInt32(Console.ReadLine());

    try
    {
        int resultado = x / y;
        Console.WriteLine($"{x} / {y} = {resultado}");
    }
    catch (Exception ex)
    {
        Console.WriteLine("\nnão é possível dividir por zero, tente outro número");
        Console.WriteLine($"\nerro: << {ex.Message} >>");
        Console.WriteLine($"\ndetalhes: {ex?.StackTrace?.ToString()}");
    }
    finally
    {
        Console.WriteLine("\nprocessamento concluído...");
    }

    Console.WriteLine("\ncontinuar? (0 encerra)");
    int opcao = Convert.ToInt32(Console.ReadLine());
    if (opcao == 0) break;
}