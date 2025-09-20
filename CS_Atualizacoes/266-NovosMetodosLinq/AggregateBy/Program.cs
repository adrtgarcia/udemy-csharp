Console.WriteLine("\nAggregateBy\n");

//var numeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//var resultado = numeros.AggregateBy(
//    keySelector: n => n % 2 == 0 ? "Par" : "Ímpar", // Agrupar por Par ou Ímpar
//    seed: 0,                                        // Valor inicial para a contagem
//    func: (contagem, _) => contagem + 1);           // Incrementar contagem p/cada elemento

//foreach (var item in resultado)
//    Console.WriteLine($"Tipo: {item.Key}, Contagem: {item.Value}");

(string nome, string departamento, int diasFerias)[] funcionarios =
[
   ("João Duda", "IT", 12),
   ("Jane Soares", "Marketing", 18),
   ("Jose Silva", "IT", 28),
   ("Maria Fernandez", "RH", 17),
   ("Nivia Maria", "Marketing", 5),
   ("Maria Moreti", "RH", 9)
];

var diasFeriasDepartamento = funcionarios
   .AggregateBy(emp => emp.departamento, 0, (acc, funci) => acc + funci.diasFerias);

foreach (var entry in diasFeriasDepartamento)
    Console.WriteLine($"O Departamento {entry.Key} possui um total de {entry.Value} dias de férias a cumprir.");


Console.ReadLine();
