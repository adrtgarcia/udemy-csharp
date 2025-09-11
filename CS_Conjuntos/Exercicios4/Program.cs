using System.Collections;

Console.WriteLine("Exercícios 04");

ArrayList pessoas = new();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o nome da {i + 1}º pessoa: ");
    string nome = Console.ReadLine();
    Console.WriteLine($"Digite a idade de {nome}: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    pessoas.Add(new Pessoa(nome, idade));
}

Console.WriteLine("\nImprimindo lista:");
foreach (Pessoa p in pessoas) p.Exibir();
// Pessoa.Exibir(pessoas);

Console.WriteLine("\nAdicionando duas pessoas...");
pessoas.Add(new Pessoa("Jaime", 20));
pessoas.Add(new Pessoa("Tânia", 18));
Console.WriteLine("\nImprimindo lista:");
foreach (Pessoa p in pessoas) p.Exibir();
// Pessoa.Exibir(pessoas);

Console.WriteLine("\nRemovendo última pessoa da lista...");
pessoas.RemoveAt(pessoas.Count - 1);
Console.WriteLine("\nImprimindo lista:");
foreach (Pessoa p in pessoas) p.Exibir();
// Pessoa.Exibir(pessoas);

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    /*
    public static void Exibir(ArrayList pessoas)
    {
        foreach (Pessoa p in pessoas)
        {
            Console.WriteLine($"\n{p.Nome}, {p.Idade} anos");
        }
    }*/

    public void Exibir()
    {
        Console.WriteLine($"{Nome}, {Idade}, anos");
    }
}