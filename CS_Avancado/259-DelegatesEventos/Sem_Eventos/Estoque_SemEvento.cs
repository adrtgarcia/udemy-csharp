namespace Sem_Eventos;

public class Estoque_SemEvento
{
    public string Produto { get; private set; }
    public int Quantidade { get; private set; }

    private int _nivelCritico;

    // Os componentes de notificação são passados
    // no construtor, criando acoplamento.
    private AlertaDeCompras _alerta;
    private SistemaDeReposicao _reposicao;

    public Estoque_SemEvento(string produto, int quantidadeInicial, int nivelCritico)
    {
        Produto = produto;
        Quantidade = quantidadeInicial;
        _nivelCritico = nivelCritico;

        // A classe Estoque agora DEPENDE diretamente das outras.
        _alerta = new AlertaDeCompras();
        _reposicao = new SistemaDeReposicao();
    }

    public void Retirar(int quantidade)
    {
        if (Quantidade >= quantidade)
        {
            Quantidade -= quantidade;
            Console.WriteLine($"\nRetirada de {quantidade} unidades de '{Produto}'. Estoque atual: {Quantidade}");

            // Verificação manual e chamada direta dos métodos.
            if (Quantidade < _nivelCritico)
            {
                _alerta.EnviarAlertaUrgente(Produto);
                _reposicao.CriarPedidoDeReposicaoAutomatico(Produto);
            }
        }
        else
        {
            Console.WriteLine("\nErro: Quantidade insuficiente em estoque.");
        }
    }
}
