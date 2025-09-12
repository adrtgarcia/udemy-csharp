Console.WriteLine("Estrutura IF-ELSE");

/*
 
sintaxe:
    if (condição)
    { 
        bloco de instruções
    } 
    else if (condição) 
    {
        bloco de instruções
    } 
    else 
    {
        bloco de instruções
    }
 
 */

Console.WriteLine("\nCliente especial? (S/N): ");
var especial = Convert.ToChar(Console.ReadLine());
if(especial == 'S')
{
    Console.WriteLine("Desconto de 10%");
}

// ou ainda:
bool ehClienteEspecial = true;
if(ehClienteEspecial)
{
    Console.WriteLine("Desconto de 10%");
}


Console.WriteLine("\nInforme a nota: ");
var nota = Convert.ToDouble(Console.ReadLine());
if(nota >= 60)
{
    Console.WriteLine("Aluno aprovado");
}
else
{
    Console.WriteLine("Aluno reprovado");
}

int x = 7, y = 9;
Console.WriteLine($"x = {x}, y = {y}");
if(x == y)
{
    Console.WriteLine($"{x} == {y}");
}
else
{
    if(x > y)
    {
        Console.WriteLine($"{x} > {y}");
    }
    else
    {
        Console.WriteLine($"{x} < {y}");
    }
}

int idade = 18;
if(idade <= 3)
{
    Console.WriteLine("É um bebê");
}
else if(idade > 3 && idade <= 13)
{
    Console.WriteLine("É uma criança");
}
else if(idade > 13 && idade <= 17)
{
    Console.WriteLine("É um adolescente");
}
else if(idade > 17 && idade <= 25)
{
    Console.WriteLine("É um jovem adulto");
}
else if(idade > 25 && idade <= 60)
{
    Console.WriteLine("É um adulto");
}
else
{
    Console.WriteLine("É um idoso");
}