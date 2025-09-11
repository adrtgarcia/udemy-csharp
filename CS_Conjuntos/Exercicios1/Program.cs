using System;

Console.WriteLine("Exercício 01\n");

string[] frutas = new string[10] 
{ 
    "Maçã", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"
 };

foreach (string f in frutas)
    Console.WriteLine(f);
Console.WriteLine($"\nTotal de frutas: {frutas.Count()}\n");

Console.WriteLine($"\n2º = {frutas[1]}");
Console.WriteLine($"9º = {frutas[8]}\n\n");

frutas[2] = "Kiwi";
frutas[9] = "Caqui";
foreach (string f in frutas)
    Console.WriteLine(f);
Console.WriteLine("\n\n");

Array.Sort(frutas);
for (int i = (frutas.Count() - 1); i >= 0; i--) 
    Console.WriteLine(frutas[i]);