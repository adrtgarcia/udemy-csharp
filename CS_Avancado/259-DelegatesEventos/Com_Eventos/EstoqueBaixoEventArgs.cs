namespace Com_Eventos;

public sealed class EstoqueBaixoEventArgs : EventArgs
{
    public string Produto { get; }
    public int QuantidadeAtual { get; }
    public DateTime DataDoAlertaUtc { get; }

    public EstoqueBaixoEventArgs(string produto, int quantidadeAtual)
    {
        Produto = produto;
        QuantidadeAtual = quantidadeAtual;
        DataDoAlertaUtc = DateTime.UtcNow;   // registrar sempre em UTC
    }
}
