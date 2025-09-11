Console.WriteLine("Structs");

/* structs são tipos de valor, classes são tipos de referência */

Cliente c1 = new("maria", 30);
Console.WriteLine($"{c1.Nome}, {c1.Idade} anos");
public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}