using CodigoGerado;

Console.WriteLine("Usando o Source Generator para gerar uma saudação\n");
Console.WriteLine("Pressione algo para ver a saudação !!!\n");

Console.ReadKey();

Console.ForegroundColor = ConsoleColor.Yellow;
Saudacao.DigaOla();
Console.ResetColor();

Console.ReadKey();

