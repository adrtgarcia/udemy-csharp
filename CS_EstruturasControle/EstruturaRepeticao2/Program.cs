Console.WriteLine("Estrutura WHILE");

/*

sintaxe:
    while(condição) 
    {
        bloco de instrções
    }

*/

Console.WriteLine("\ncontagem regressiva: ");
int i = 10;
while(i > 0)
{
    Console.WriteLine(i);
    i--;
}
Console.WriteLine("fim da contagem");

int numero = 9;
i = 0;
Console.WriteLine($"\ntabuada do {numero}:");
while(i <= 10)
{
    Console.WriteLine($"{i} * {numero} = {i * numero}");
    i++;
}

while(true)
{
    Console.WriteLine("\ndigite um numero (-1 para parar): ");
    numero = Convert.ToInt32(Console.ReadLine());
    if(numero == -1)
        break;
    else if(numero % 2 == 0)
        Console.WriteLine($"{numero} é par");
    else
        Console.WriteLine($"{numero} é ímpar");
}

Console.WriteLine("\nplano cartesiano:");
int x = 0;
while(x < 5)
{
    int y = 0;
    while(y < 5)
    {
        Console.Write($"({x}, {y}) ");
        y++;
    }
    Console.Write("\n");
    x++;
}