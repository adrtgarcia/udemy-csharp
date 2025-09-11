Console.WriteLine("Gabarito: Exercício Prático 2");

/*
 
    STRUCT:
        usada para estruturar dados comuns em um mesmo contexto, semelhantes as classes
            - CLASSE: tipo de referência, alocada na heap e coletada pelo garbage collector
            - STRUCT: tipo de valor, alocada na stack
        assim, é útil para situações onde se precisa de poucas variáveis, pois um objeto de 
        struct é mais leve que de classe e, por ser do tipo de valor, não trabalha com referências e
        é desalocado da memória stack após sua utilização
 
 */

Cliente cliente = new("Maria", "maria@email", 19);
Console.WriteLine("\nInformando idade:");
Cliente.ExibirInfo(email: cliente.Email, nome: cliente.Nome, idade: cliente.Idade);
Console.WriteLine("\nSem informar idade:");
Cliente.ExibirInfo(email: cliente.Email, nome: cliente.Nome);

public struct Cliente
{
    public string Nome;
    public string Email;

    private int idade;
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 18)
            {
                idade = 18;
                Console.WriteLine("Cliente menor que 18 anos");
            }
            else
            {
                idade = value;
                Console.WriteLine("Cliente maior que 18 anos");
            }
        }
    }

    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public static void ExibirInfo(string nome, string email, int idade = 18)
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Idade: {idade}");
    }
}