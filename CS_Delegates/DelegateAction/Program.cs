Console.WriteLine("Delegates Pré-Definidos: Action");

/*
 
    Action<T> representa um método que não retorna um valor, mas pode receber até 16 argumentos
    de entrada, útil para representar um método que executa uma ação, sem retornar nenhum valor

        delegate void Action<in T>(T obj);

 */

Console.WriteLine("\nInforme um número inteiro:");
int numero = Convert.ToInt32(Console.ReadLine());

Action<int> delDuplicar = numero => Console.WriteLine($"{numero} * 2 = {numero * 2}");
delDuplicar(numero);


/* versão original:

Duplicar(numero);

static void Duplicar(int numero)
{
    int resultado = numero * 2;
    Console.WriteLine($"{numero} * 2 = {resultado}");
}
 */