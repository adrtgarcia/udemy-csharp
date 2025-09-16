Console.WriteLine("Delegates Pré-Definidos: Function");

/*
 
    Func<T, TResult> recebe até 16 argumentos do tipo T e retorna um valor do tipo TResult,
    útil para representar um método que executa uma operação e retorna um resultado
 
        public delegate TResult Func<int T, out TResult>(T arg);

 */

Console.WriteLine("\nDigite um número:");
double numero = Convert.ToDouble(Console.ReadLine());

Func<double, double> raizQuadrada = x => Math.Sqrt(x);
double resultado = raizQuadrada(numero);

Console.WriteLine($"Raiz quadrada de {numero} é {resultado}");
