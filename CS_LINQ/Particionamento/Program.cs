Console.WriteLine("Operadores de Particionamento");

Console.WriteLine("\nTAKE");
/* retorna os n primeiros elementos */

List<int> numeros = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 ];
List<int> numPrimeiros = numeros.Take(4).ToList();
foreach (var num in numPrimeiros)
    Console.Write(num + "  ");
Console.WriteLine("\n");

List<int> numRevPrimeiros = numeros.OrderByDescending(n => n).Take(5).ToList();
foreach (var num in numRevPrimeiros)
    Console.WriteLine(num + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nTAKE WHILE");
/* retorna os n primeiros elementos que satisfazem uma dada condição */

List<int> numMenor6 = numeros.TakeWhile(n => n < 6).ToList();
foreach (var num in numMenor6) /* toma os primeiros elementos antes do elemento = 6 */
    Console.Write(num + "  ");
Console.WriteLine("\n");

List<int> whereMenor6 = numeros.Where(n => n < 6).ToList();
foreach (var num in whereMenor6) /* retorna todos os elementos menores que 6 */
    Console.Write(num + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nSKIP");
/* ignora n primeiros elementos e retorna os restantes */

List<int> numResta = numeros.Skip(4).ToList();
foreach (var num in numResta)
    Console.Write(num + "  ");
Console.WriteLine();

List<int> numMaior3 = numeros.Where(n => n > 3).Skip(3).ToList();
foreach (var num in numMaior3)
    Console.Write(num + "  ");
Console.WriteLine();

List<int> numMenor7 = numeros.Skip(4).Where(n => n < 7).ToList();
foreach (var num in numMenor7)
    Console.Write(num + "  ");
Console.WriteLine();

Console.WriteLine("\nSKIP WHILE");
/* ignora n primeiros elementos que satisfazem uma dada condição */

List<int> numMenor5 = numeros.SkipWhile(n => n < 5).ToList();
foreach (var num in numMenor5)
    Console.Write(num + "  ");
Console.WriteLine();

List<string> nomes = [ "sara", "joão", "josé", "ana", "maria" ];
List<string> listaNomes = nomes.SkipWhile((nome, index) => nome.Length > index).ToList();
foreach (var n in listaNomes)
    Console.Write(nomes + "  ");
Console.WriteLine();
