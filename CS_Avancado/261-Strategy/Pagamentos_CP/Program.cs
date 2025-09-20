Console.WriteLine("Exemplo Usando o padrão Factory Method\n");

Console.WriteLine("Digite o tipo de pagamento (PIX, Boleto, Cartao):");
var tipo = Console.ReadLine();



Console.ReadKey();

//1. Interface e implementações concretas (reutilizáveis)
public interface IPagamento
{
    void RealizarPagamento();
}
public class PagamentoPix : IPagamento
{
    public void RealizarPagamento() => 
        Console.WriteLine("Pagamento realizado via PIX.");
}
public class PagamentoBoleto : IPagamento
{
    public void RealizarPagamento() => 
        Console.WriteLine("Pagamento realizado via Boleto.");
}
public class PagamentoCartao : IPagamento
{
    public void RealizarPagamento() => 
        Console.WriteLine("Pagamento realizado via Cartão.");
}

