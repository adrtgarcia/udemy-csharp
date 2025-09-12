Console.WriteLine("Estrutura FOR");

/*

sintaxe:
    for(inicialização; condição; iteração) 
    {
        instruções
    }

*/

Console.WriteLine("\npares entre 0-10");
for(int i = 0; i <= 10; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("\nmatriz:");
for(int i = 5; i > 0; i--)
{
    for(int j = i; j > 0; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}