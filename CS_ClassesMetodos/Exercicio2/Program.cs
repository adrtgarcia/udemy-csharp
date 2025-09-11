using System.Runtime.InteropServices;

Console.WriteLine("Campo estático - Exercício");

ContaCorrente c1 = new(123, "maria");
ContaCorrente c2 = new(456, "joao");

c1.ExibirContaCorrente();
c2.ExibirContaCorrente();

public class ContaCorrente
{
    public int conta;
    public string? nome;
    public static float juros = 0.05f;

    public ContaCorrente(int conta, string nome)
    {
        this.conta = conta;
        this.nome = nome;
    }

    public float ObterJurosAnual()
    {
        return juros * 12;
    }

    public void ExibirContaCorrente()
    {
        Console.WriteLine($"\nconta: {conta}");
        Console.WriteLine($"\nnome: {nome}");
        Console.WriteLine($"\njuros mensais: {juros}");
    }
}