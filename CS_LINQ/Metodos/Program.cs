Console.WriteLine("Métodos Append<T>, Prepend<T> e Zip");

Console.WriteLine("\nAPPEND<T>");
/* anexa um valor ao final da sequência sem modificar seus elementos */
/* cria uma cópia da sequência original com o novo elemento */

List<int> numeros = [ 1, 2, 3, 4 ];
var novaListaNumeros = numeros.Append(5);

foreach (var n in numeros)
    Console.Write(n + "  ");
Console.WriteLine("\n");

foreach (var n in novaListaNumeros)
    Console.Write(n + "  ");
Console.WriteLine("\n");

List<int> novosNumeros = numeros.Append(5).ToList();
foreach (var n in novosNumeros)
    Console.Write(n + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nPREPEND<T>");
/* anexa um valor ao início da sequência sem modificar seus elementos */
/* cria uma cópia da sequência original com o novo elemento */

List<string> nomes = ["maria", "joão", "josé"];
var novaListaNomes = nomes.Prepend("ana");

foreach (var n in nomes)
    Console.Write(n + "  ");
Console.WriteLine("\n");

foreach (var n in novaListaNomes)
    Console.Write(n + "  ");
Console.WriteLine("\n");

List<string> novosNomes = nomes.Prepend("ana").ToList();
foreach (var n in novosNumeros)
    Console.Write(n + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nZip");
/* aplica uma função específica aos elementos correspondentes de duas sequências 
   e produz uma sequência dos resultados */

int[] arrayNumeros = { 10, 20, 30, 40, 50 };
string[] arrayNomes = { "dez", "vinte", "trinta", "quarenta" };
var nomesNumeros = arrayNumeros.Zip(arrayNomes, (prim, seg) => prim + " - " + seg);
foreach (var n in nomesNumeros)
    Console.WriteLine(n);
Console.WriteLine();

var num1 = new[] { 1, 2, 3 };
var num2 = new[] { 20, 30, 40 };
var resultado = num1.Zip(num2, (a, b) => a * b);
foreach (var r in resultado)
    Console.WriteLine(r);
Console.WriteLine();
