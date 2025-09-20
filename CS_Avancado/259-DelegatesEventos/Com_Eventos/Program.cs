// *** Programa de demonstração ***
using Com_Eventos;

Console.WriteLine("\n ### Exemplo monitoração de limite usando Eventos ###\n");
Console.ReadKey();

var cafe = new Estoque_ComEvento("Café", quantidadeInicial: 100, nivelCritico: 20);
var acucar = new Estoque_ComEvento("Açúcar", quantidadeInicial: 50, nivelCritico: 10);

// Inscreve‑se no mesmo manipulador para ambos os estoques.
void AlertaDeEstoque(object? sender, EstoqueBaixoEventArgs e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(
        $"{e.Produto} em nível crítico: {e.QuantidadeAtual} un. (UTC {e.DataDoAlertaUtc:u})");
    Console.ResetColor();
}

cafe.EstoqueBaixo += AlertaDeEstoque;
acucar.EstoqueBaixo += AlertaDeEstoque;

Console.WriteLine("== Movimento de estoque ==");

// Simula retiradas em cada produto.
cafe.Retirar(30);    // estoque 70 – ainda acima do crítico
acucar.Retirar(25);  // estoque 25 – ainda acima

cafe.Retirar(50);    // estoque 20 – exatamente no crítico, não dispara
cafe.Retirar(5);    // estoque 15 – agora dispara o alerta

acucar.Retirar(20);  // estoque 5  – dispara o alerta

Console.WriteLine("\nProcesso concluído. Pressione algo para sair.");
Console.ReadKey();