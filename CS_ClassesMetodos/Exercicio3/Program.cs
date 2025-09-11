Console.WriteLine("Propriedades - Exercício");

Produto p1 = new();
p1.Nome = "caderno";
p1.Preco = 10.00;
p1.EstoqueMinimo = 20;

p1.ExibirInfo();

public class Produto
{
    private string? nome;
    public string? Nome 
    {
        get { return nome.ToUpper(); }
        set { nome = value; } 
    }

    private double preco;
    public double Preco 
    {
        get { return preco; } 
        set
        { 
            if (value <= 0) 
                preco = 5.00;
            else 
                preco = value;
        } 
    }

    private double desconto = 0.05;
    public double Desconto { get { return desconto; } }
    public double PrecoFinal { get { return Preco - (Preco * Desconto); } }
    private int estoqueMinimo;
    public int EstoqueMinimo { set { estoqueMinimo = value; } }

    public void ExibirInfo()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"\nPreço: {Preco.ToString("c")}");
        Console.WriteLine($"\nDesconto: {Desconto}");
        Console.WriteLine($"\nPreço final: {PrecoFinal.ToString("c")}");
        /*Console.WriteLine($"\nEstoque mínimo: {EstoqueMinimo}");*/
        Console.WriteLine($"\nEstoque mínimo: {estoqueMinimo}"); 
    }
}