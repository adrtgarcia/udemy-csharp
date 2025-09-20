Console.WriteLine("Delegates Pré-Definidos: Predicate");

/*
 
    Predicate<T> representa um método que recebe um único argumento do tipo T e retorna
    um valor booleano, podendo ser usado para testar se um objeto satisfaz uma dada condição 
 
        public delegate bool Predicate<in T>(T obj);
 */

// código original:

Console.WriteLine("\nInforme um número inteiro:");
int numero = Convert.ToInt32(Console.ReadLine());

Predicate<int> delegatePar = x => x % 2 == 0;

if (delegatePar(numero))
    Console.WriteLine($"{numero} é par");
else
    Console.WriteLine($"{numero} é ímpar");


/* versão original:

if (VerificaPar(numero))
    Console.WriteLine($"{numero} é par");
else
    Console.WriteLine($"{numero} é ímpar");

static bool VerificaPar(int numero)
{
    if (numero % 2 == 0)
        return true;
    else
        return false;
}
 */