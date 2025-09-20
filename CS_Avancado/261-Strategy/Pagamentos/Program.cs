
Console.WriteLine("Exemplo sem usar padrão de projeto\n");

Console.WriteLine("Digite o tipo de pagamento (PIX, Boleto, Cartao):");
string tipo = Console.ReadLine()!;

var pagamento = CriarPagamento(tipo);
pagamento.RealizarPagamento();

Console.ReadKey();

//Toda vez que surge um novo tipo de pagamento, você precisa alterar esse método.
// Quebra o princípio OCP (Open/Closed Principle).
// Dificulta testes e manutenção.
static IPagamento CriarPagamento(string tipo)
{
    //Código acoplado e propenso a erro
    if (tipo == "PIX") return new PagamentoPix();
    if (tipo == "Boleto") return new PagamentoBoleto();
    return new PagamentoCartao(); // padrão
}
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