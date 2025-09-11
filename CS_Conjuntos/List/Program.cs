Console.WriteLine("List");

/*
    coleção de objetos fortemente tipados, que podem ser acessados
    usando um índice, e possui métodos para classificar, pesquisar, modificar e manipular
    listas
        - versão genérica do arraylist
        - mais indicado quando se tem uma coleção heterogênea

    métodos:
        - Add, AddRange, Insert, InsertRange
        - Contains
        - Remove, RemoveAt, RemoveRange
        - Sort, Clear
*/

List<string> lista = new() { "joão", "maria", "josé" };
ExibirLista(lista);

Console.WriteLine("\nadicionando ana");
lista.Add("ana");
ExibirLista(lista);

Console.WriteLine("\nadicionando [paulo, pedro]");
List<string> nomes = new() { "paulo", "pedro" };
lista.AddRange(nomes);
ExibirLista(lista);

Console.WriteLine("\nadicionando marina na posição 1");
lista.Insert(1, "marina");
ExibirLista(lista);

Console.WriteLine("\nadicionando [paulo, pedro] na posição 0");
lista.InsertRange(0, nomes);
ExibirLista(lista);

Console.WriteLine($"\nexiste ana? {lista.Contains("ana")}");
Console.WriteLine($"\nexiste amanda? {lista.Contains("amanda")}");
ExibirLista(lista);

Console.WriteLine("\nremovendo paulo");
lista.Remove("paulo");
ExibirLista(lista);

Console.WriteLine("\nremovendo item na posição 3");
lista.RemoveAt(3);
ExibirLista(lista);

Console.WriteLine("\nremovendo 2 itens a partir da posição 3");
lista.RemoveRange(3, 2);
ExibirLista(lista);

Console.WriteLine("\nordenando a lista");
lista.Sort();
ExibirLista(lista);

Console.WriteLine("\nlimpando a lista");
lista.Clear();
ExibirLista(lista);

static void ExibirLista(List<string> lista)
{
    Console.WriteLine($"\nnúmero de elementos: {lista.Count()}");
    foreach (var item in lista) Console.Write($"{item}\t");
    Console.WriteLine("\n\n");
} 