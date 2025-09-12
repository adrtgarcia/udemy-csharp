// EX01
using System.Collections.Concurrent;

Console.WriteLine("digite um número: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digite um número: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digite um número: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2 && num1 >= num3)
    Console.WriteLine($"{num1} é o maior número");
else if (num2 >= num1 && num2 >= num3)
    Console.WriteLine($"{num2} é o maior número");
else
    Console.WriteLine($"{num3} é o maior número");


// EX02
Console.WriteLine("\ndigite o valor de a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite o valor de b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite o valor de c: ");
double c = Convert.ToDouble(Console.ReadLine());

double delta = (b * b) - (4 * a * c);
if(delta < 0)
{
    Console.WriteLine("as raízes são imaginárias");
    Console.WriteLine("sem solução para os números reais");
} 
else if(delta == 0)
{
    double x = (-b + Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine("raíz real única");
    Console.WriteLine($"x = {x}");
}
else
{
    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine("ambas as raízes são reais e diferentes");
    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
}


// EX03
int soma = 0, i = 1;

Console.WriteLine("\nos 10 primeiros números naturais são: ");
while(i <= 10)
{
    Console.Write($"{i} ");
    soma += i;
    i++;
}
Console.WriteLine($"a soma dos números é {soma}");

soma = 0; i = 1;
Console.WriteLine("\nos 10 primeiros números naturais são: ");
do
{
    Console.Write($"{i} ");
    soma += i;
    i++;
} while (i <= 10);
Console.WriteLine($"a soma dos números é {soma}");

Console.WriteLine("\nos 10 primeiros números naturais são: ");
for (i = 1, soma = 0; i <= 10; i++)
{
    Console.Write($"{i} ");
    soma += i;
}
Console.WriteLine($"a soma dos números é {soma}");


// EX04
int numero;
while (true)
{
    Console.WriteLine("\ndigite um número (-1 encerra):");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero == -1)
        break;
    else if (numero <= 0)
        Console.WriteLine("o número precisa ser maior que 0");
    else
    {
        for(i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} * {numero} = {i * numero}");
        }
    }
}


// EX05
bool continua = true;
while (continua)
{
    Console.WriteLine("\nqual a instrução para sair de um loop?");
    Console.WriteLine("a. quit");
    Console.WriteLine("b. continue");
    Console.WriteLine("c. break");
    Console.WriteLine("d. exit");
    char resposta = Convert.ToChar(Console.ReadLine());

    if (resposta == 'c')
    {
        continua = false;
        Console.WriteLine();
    }
}


// EX06
Console.WriteLine("\nimprimindo números:");
for(i = 10; i <= 20; i = i + 2)
{
    if (i == 16)
        continue;
    Console.Write(i + " ");
}

for(i = 10; i <= 20; i = i + 1)
{
    if (i == 16)
        continue;
    if (i % 2 == 0)
        Console.Write(i + " ");
}

i = 10;
while(true)
{
    if (i == 16)
        continue;
    if (i == 20)
        break;
    Console.Write(i + " ");
    i++;
}


// EX07
Console.WriteLine("\ninforme o número de linhas:");
int linhas = Convert.ToInt32(Console.ReadLine());
for(i = 1; i <= linhas; i++)
{
    for(int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


// EX08
Console.WriteLine("\ndigite um número:");
numero = Convert.ToInt32(Console.ReadLine());
int fatorial = 1;
for(i = numero; i > 0; i--)
{
    fatorial *= numero;
}
Console.WriteLine($"o fatorial de {numero} é {fatorial}");


// EX09
Console.WriteLine("\nimprimindo tabuadas...");
int fator1 = 2, fator2 = 1;
do
{
    do
    {
        Console.WriteLine($"{fator1} * {fator2} = {fator1 * fator2}");
        fator2++;
    } while (fator2 <= 10);
    Console.WriteLine();
    fator1++;
} while (fator1 <= 6);


// EX10
while(true)
{
    Console.WriteLine("\ninforme a nota (-1 encerra):");
    int nota = Convert.ToInt32(Console.ReadLine());
    if (nota == -1)
    {
        Console.WriteLine("encerrando o programa");
        break;
    }
    switch (nota)
    {
        case 10:
            Console.WriteLine("avaliação: A+");
            break;
        case 9:
            Console.WriteLine("avaliação: A");
            break;
        case 8:
        case 7:
            Console.WriteLine("avaliação: B");
            break;
        case 6:
            Console.WriteLine("avaliação: C");
            break;
        case 5:
            Console.WriteLine("avaliação: E");
            break;
        case 4:
        case 3:
        case 2:
        case 1:
        case 0:
            Console.WriteLine("avaliação: F");
            break;
        default:
            Console.WriteLine("nota informada inválida");
            break;
    }
}


// EX11
Console.WriteLine("\ninforme o primeiro numero:");
double numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("informe o operador:");
char operador = Convert.ToChar(Console.ReadLine());
Console.WriteLine("\ninforme o segundo numero:");
double numero2 = Convert.ToInt32(Console.ReadLine());

switch (operador)
{
    case '+':
        Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
        break;
    case '-':
        Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
        break;
    case '*':
        Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
        break;
    case '/':
        if (numero2 == 0)
        {
            Console.WriteLine("não é possível dividir por zero");
            Console.WriteLine($"{numero1} / {numero2} = infinito");
            break;
        }
        Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
        break;
    default:
        Console.WriteLine("operador inválido");
        break;
}