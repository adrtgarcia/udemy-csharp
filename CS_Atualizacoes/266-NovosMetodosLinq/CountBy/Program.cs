Console.WriteLine("\nCountBy\n");

//var nomes = new[] { "Ana", "Bruno", "Ana", "Carlos", "Ana", "Bruno" };

//var contagem = nomes.CountBy(x => x);

(string nome, string sobrenome)[] pessoas =
[
   ("João", "Donato"),
   ("Janice", "Silva"),
   ("João", "Sanches"),
   ("Maria", "Silveira"),
   ("Pedro", "Sobrinho"),
   ("Janice", "Fernandez"),
   ("Maria", "Moretii")
];

var contaNomes = pessoas.CountBy(p => p.nome);

foreach (var entry in contaNomes)
  Console.WriteLine($"O Nome {entry.Key} aparece {entry.Value} vezes");



Console.ReadLine();