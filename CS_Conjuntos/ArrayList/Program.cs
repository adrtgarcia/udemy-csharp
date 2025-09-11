using System.Collections;

Console.WriteLine("ArrayList");
/* 
    array dinâmico, aceita vários tipos de elementos 
    ao mesmo tempo (mas não é recomendada para isso -> usar List<Object>)
*/

ArrayList lista1;
lista1 = new ArrayList();
ArrayList lista2 = new ArrayList();
var lista3 = new ArrayList();
ArrayList lista4 = new();

/* 
    count: quantos elementos existem
    capacity: quanto elementos suporta 
*/

ArrayList lista5;
lista5 = new ArrayList(5);
ArrayList lista6 = new ArrayList(10);
var lista7 = new ArrayList(12);
ArrayList lista8 = new(4);

ArrayList lista9 = new();
lista9.Add("maria");
lista9.Add(4.5);
lista9.Add(true);
lista9.Add(" ");
lista9.Add(null);

ArrayList lista10 = new ArrayList() { "maria", 4.5, true, " ", null };
ArrayList lista11 = new() { "maria", 4.5, true, " ", null };


/* 
    métodos disponíveis
        - Add: inclui um único elemento ao final
        - Insert: incluir um elemento em uma posição qualquer por meio do índice
        - AddRange: inclui um conjunto de elemento no final
        - InsertRange: inclui um conjunto de elementos em um posição específica
        - Remove: remove a primeira ocorrência de um objeto específico
        - RemoveAt: remove o elemento de uma posição específica
        - RemoveRange: remove um número definido de elementos a partir de uma posição específica
        - Contains: determina se um dado elemento existe ou não
        - Sort: elementos são ordenados de forma ascendente (APENAS SE SÓ EXISTIR 1 TIPO)
        - Clear: remove todos os elementos
 */

Console.WriteLine("\n\narray inicial:");
ArrayList lista = new() { "maria", 5, 3.9, false, 'a' };
foreach (var elemento in lista) Console.Write($"{elemento}  ");
Console.WriteLine("\n\n");

Console.WriteLine("\nadicionando ana, true");
lista.Add("ana");
lista.Add(true);
foreach (var elemento in lista) Console.Write($"{elemento}  ");
Console.WriteLine("\n\n");

Console.WriteLine("\nadicionando 0 na posição 2");
lista.Insert(2, 0);
foreach (var elemento in lista) Console.Write($"{elemento}  ");
Console.WriteLine("\n\n");

Console.WriteLine("\nadicionando [1, 2, 3]");
int[] numeros = { 1, 2, 3 };
lista.AddRange(numeros);
foreach (var elemento in lista) Console.Write($"{elemento}  ");
Console.WriteLine("\n\n");

Console.WriteLine("\nadicionando [1, 2, 3] na posição 4");
lista.InsertRange(4, numeros);
foreach (var elemento in lista) Console.Write($"{elemento}  ");
Console.WriteLine("\n\n");

Console.WriteLine("\nremovendo 1");
lista.Remove(1);
foreach (var elemento in lista) Console.Write($"{elemento}  ");
Console.WriteLine("\n\n");

Console.WriteLine("\nremovendo objeto na posição 5");
lista.RemoveAt(5);
foreach (var elemento in lista) Console.Write($"{elemento}  ");
Console.WriteLine("\n\n");

Console.WriteLine("\nremovendo 3 objetos a partir da posição 3");
lista.RemoveRange(3, 3);
foreach (var elemento in lista) Console.Write($"{elemento}  ");
Console.WriteLine("\n\n");

Console.WriteLine($"\nexiste o elemento 3? {lista.Contains(3)}");
foreach (var elemento in lista) Console.Write($"{elemento}  ");
Console.WriteLine("\n\n");

Console.WriteLine("\ncriando um array de string e usando sort");
ArrayList nomes = new() { "maria", "carlos", "dina", "ana" };
foreach (var elemento in nomes) Console.Write($"{elemento}   ");
Console.WriteLine("\n");
nomes.Sort();
foreach (var elemento in nomes) Console.Write($"{elemento}   ");
Console.WriteLine("\n\n");

Console.WriteLine("\napagando todos os elementos");
lista.Clear();
foreach (var elemento in lista) Console.WriteLine($"{elemento}");
Console.WriteLine("\n\n");