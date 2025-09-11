Console.WriteLine("Exemplo Prático");

Cadastro cad = new();
var cliente = cad.RegistrarCliente();
cad.ExibirDados(cliente);

cliente = cad.RegistrarCliente(cliente);
cad.ExibirDados("Renda alterada", cliente);

public class Cliente
{
    public string? nome;
    public int idade;
    public decimal renda;

    public Cliente(string nome, int idade, decimal renda)
    {
        this.nome = nome;
        this.idade = idade;
        this.renda = renda;
    }

    public Cliente() { }
}

public class Cadastro
{
    public Cliente RegistrarCliente()
    {
        Cliente c = new("Maria", 23, 3000);
        return c;
    }

    public Cliente RegistrarCliente(Cliente c)
    {
        c.renda = 3500;
        return c;
    }

    public void ExibirDados(Cliente c)
    {
        Console.WriteLine($"\nNome: {c.nome}");
        Console.WriteLine($"Idade: {c.idade}");
        Console.WriteLine($"Renda: {c.renda.ToString("c")}");
    }

    public void ExibirDados(string texto, Cliente c)
    {
        Console.WriteLine($"\n{texto}");
        Console.WriteLine($"{c.nome} - {c.renda.ToString("c")}");
    }
}