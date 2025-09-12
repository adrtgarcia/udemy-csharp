Console.WriteLine("Estrutura DO-WHILE");

/*

sintaxe:
    do 
    {
        bloco de instrções
    }
    while(condição)

*/

int opcao;
do
{
    Console.WriteLine("\nescolha uma opção (1-3): ");
    opcao = Convert.ToInt32(Console.ReadLine());
    if (opcao == 1)
        Console.WriteLine("batata-frita");
    else if (opcao == 2)
        Console.WriteLine("sanduíche");
    else if (opcao == 3)
        Console.WriteLine("refrigerante");
}
while (opcao >= 1 && opcao <= 3);

int numero;
do
{
    Console.WriteLine("\ndigite um número (-1 encerra): ");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero == -1)
        break;
    else if (numero % 2 == 0)
        Console.WriteLine($"{numero} é par");
    else
        Console.WriteLine($"{numero} é ímpar");
}
while (true);

Console.WriteLine("\nplano cartesiano:");
int x = 0;
do
{
    int y = 0;
    do
    {
        Console.Write($"({x}, {y}) ");
        y++;
    }
    while (y < 5);
    x++;
    Console.Write("\n");
}
while (x < 5);