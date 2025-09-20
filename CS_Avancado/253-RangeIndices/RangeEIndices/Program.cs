Console.WriteLine("Usando Índices\n");

string[] nomes = { "Maria", "Paulo", "Carlos" };

string ultimoNomeAntigo = nomes[nomes.Length - 1];

// Agora com C# 8+ Indices:
string ultimoNomeNovo = nomes[^1]; // "Carlos" o primeiro elemento a partir do final
Console.WriteLine(ultimoNomeNovo);

string penultimoNome = nomes[^2];//^2 acessa o penúltimo
Console.WriteLine(penultimoNome);

string antepenultimoNome = nomes[^3];//^3 acessa o antepenúltimo
Console.WriteLine(antepenultimoNome);

// coleção ou array nulo
string[] arrayNulo = null!;

try
{
    Console.WriteLine("\nTentando acessar o último elemento de um array nulo:");
    string elementoNulo = arrayNulo![^1]; // Isso vai lançar uma exceção!
    Console.WriteLine($"Elemento: {elementoNulo}"); // Esta linha não será executada
}
catch (NullReferenceException ex) // Ou um catch genérico para Exception
{
    Console.WriteLine($"Ops! Capturamos uma exceção: {ex.GetType().Name} - {ex.Message}");
}
Console.ReadKey();