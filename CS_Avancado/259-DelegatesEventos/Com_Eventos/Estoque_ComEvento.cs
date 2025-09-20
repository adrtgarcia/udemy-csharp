namespace Com_Eventos;

public class Estoque_ComEvento
{
    /// <summary>
    /// Disparado quando <see cref="Quantidade"/> cai abaixo de <see cref="_nivelCritico"/>.
    /// </summary>
    public event EventHandler<EstoqueBaixoEventArgs>? EstoqueBaixo;

    public string Produto { get; }
    public int Quantidade { get; private set; }

    private readonly int _nivelCritico;

    public Estoque_ComEvento(string produto, int quantidadeInicial, int nivelCritico)
    {
        if (string.IsNullOrWhiteSpace(produto))
            throw new ArgumentException("Nome do produto é obrigatório.", nameof(produto));

        if (quantidadeInicial < 0)
            throw new ArgumentOutOfRangeException(nameof(quantidadeInicial));

        if (nivelCritico < 0)
            throw new ArgumentOutOfRangeException(nameof(nivelCritico));

        Produto = produto;
        Quantidade = quantidadeInicial;
        _nivelCritico = nivelCritico;

        // Se já começar abaixo do nível crítico, avisa logo.
        if (Quantidade < _nivelCritico)
            OnEstoqueBaixo();
    }

    public void Retirar(int quantidade)
    {
        if (quantidade <= 0)
            throw new ArgumentOutOfRangeException(nameof(quantidade), "Quantidade deve ser positiva.");

        if (Quantidade < quantidade)
            throw new InvalidOperationException("Quantidade insuficiente em estoque.");

        Quantidade -= quantidade;
        Console.WriteLine($"Retirada de {quantidade} un. de '{Produto}'. Estoque atual: {Quantidade}");

        if (Quantidade < _nivelCritico)
            OnEstoqueBaixo();
    }

    private void OnEstoqueBaixo() =>
        EstoqueBaixo?.Invoke(this, new EstoqueBaixoEventArgs(Produto, Quantidade));
}
