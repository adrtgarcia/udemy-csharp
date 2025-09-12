Console.WriteLine("Entrada de Dados");

/*

Métodos IO

WriteLine(): Imprime e salta linha
Write(): Apenas imprime
 
ReadLine(): Lê uma string, retorna essa string
Read(): Lê um caractere, retorna seu código ASCII
ReadKey(): Lê um caractere, obtém a próxima tecla pressionada, retorna ConsoleKeyInfo
 
 */

Console.WriteLine("\nInforme seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"\nOlá, {nome}");

Console.WriteLine("\nInforme sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\nVocê tem {idade} anos");

