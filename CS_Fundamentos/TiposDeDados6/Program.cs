Console.WriteLine("hello world");

/*
 
ATALHOS:
ctrl + f5 >> executa o código sem depuração
f5 >> executa o código com depuração
ctrl + k + d >> organiza o código
ctrl + d >> duplica a linha onde o cursor está
ctrl + f >> localiza algo no documento atual

*/

Console.WriteLine("Nullable Types");

int valor = 100;
Console.WriteLine(valor);

/*
 
valor = null; <- compilador não aceita, não é possível converter tipo de valor em NULL

para guardar null, a variável deve ser do tipo anulável:
Nullable<Type> nome = null;

* declaração simplificada: tipo? nome = null;
* operador de coalescência nula (??)
 
*/

Nullable<bool> teste1 = null;
Console.WriteLine(teste1);

int? teste2 = null;
Console.WriteLine(teste2);

int? a = null;
// int b = a; <- compilador não permite
int b = a ?? 0;
Console.WriteLine(b);

a = 1;
b = a ?? 0;
Console.WriteLine(b);


/*

int? x = 2;
int y = 3;
int z = x * y; <- não é possível converter null em int

*/

int? x = 2;
int? y = 3;
int? z = x * y;
Console.WriteLine(z);

int? c = 100;
if(c.HasValue)
{
    Console.WriteLine($"c = {c.Value}");
} else
{
    Console.WriteLine("c não possui valor");
}
