Console.WriteLine("Operadores de Geração");

Console.WriteLine("\nRANGE");
/* gera uma coleção que contém uma sequência de números */

var numeros = Enumerable.Range(1, 10);
foreach (var n in numeros) Console.Write(n + "  ");
Console.WriteLine("\n");

var pares = Enumerable.Range(10, 30).Where(n => n % 2 == 0);
foreach (var p in pares) Console.Write(p + "  ");
Console.WriteLine("\n");

var quadrados = Enumerable.Range(1, 10).Select(n => n * n);
foreach (var q in quadrados) Console.Write(q + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nREPEAT<T>");
/* gera uma coleção que contém um valor repetido */

var str = Enumerable.Repeat("LINQ", 10);
foreach (var s in str)
    Console.WriteLine(s);
Console.WriteLine();

var num2025 = Enumerable.Repeat(2025, 10);
foreach (var n in num2025)
    Console.WriteLine(n);
Console.WriteLine();

Console.WriteLine("\nEMPTY<T>");
/* retorna uma coleção vazia */

var vazio = Enumerable.Empty<string>();
Console.WriteLine(vazio.GetType().Name);
Console.WriteLine(vazio.Count());
foreach (var v in vazio)
    Console.WriteLine(v);
Console.WriteLine();

/* 
   pode ser útil para lidar com exceções:
 
   IEnumerable<int> resultado = GetData() ?? Enumerable.Empty<int>();
        - se GetData() retorna null, o Empty vai retornar uma coleção vazia, evitando a exceção
 */
