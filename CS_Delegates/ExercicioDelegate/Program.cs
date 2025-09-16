Console.WriteLine("Exercícios: Delegate");

List<Pessoa> pessoas = new() 
{
    new Pessoa("João", 20),
    new Pessoa("Maria", 18),
    new Pessoa("Pedro", 25),
    new Pessoa("Carlos", 15),
    new Pessoa("Ana", 17)
};

Console.WriteLine("\nImprimindo as informações da lista...");
Action<Pessoa> delListar = p => Console.WriteLine($"{p.Nome}, {p.Idade} anos");
pessoas.ForEach(delListar);
Console.WriteLine();

Console.WriteLine("\nFiltrando os maiores de 18...");
Predicate<Pessoa> delFiltrar = p => p.Idade > 18;
var maiores = pessoas.FindAll(delFiltrar);
maiores.ForEach(delListar);
Console.WriteLine();

Console.WriteLine("\nBuscando a pessoa mais velha...");
Func<Pessoa, int> delObterMaisVelho = p => p.Idade;
/* int maiorIdade = pessoas.Max(delMaisVelho);
var maisVelho = pessoas.Find(p => p.Idade == maiorIdade); */
var maisVelho = pessoas.MaxBy(delObterMaisVelho);
Console.WriteLine($"{maisVelho.Nome}, {maisVelho.Idade} anos");
Console.WriteLine();

public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}