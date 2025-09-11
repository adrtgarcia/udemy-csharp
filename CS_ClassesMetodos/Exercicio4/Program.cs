Console.WriteLine("Exercício Prático - 02");

Cliente cliente = new("maria", "maria@email.com", 20);
Cliente.ExibirInfo(nome: cliente.nome, idade: cliente.Idade, email: cliente.email);
Cliente.ExibirInfo(email: cliente.email, nome: cliente.nome);

public struct Cliente
{
    public string? nome;
    public string? email;

    private int idade;
    public int Idade 
    {
        get { return idade; }
        set 
        { 
            if (value < 18) idade = 18;
            else idade = value;
        } 
    }

    public Cliente(string? nome, string? email, int idade)
    {
        this.nome = nome;
        this.email = email;
        Idade = idade;
    }

    public static void ExibirInfo(string? nome, string? email, int idade = 18)
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Idade: {idade}");
    }
}