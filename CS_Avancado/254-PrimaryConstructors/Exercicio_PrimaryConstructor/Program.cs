public class Pedido
{
    public Guid ClienteId { get; }
    public List<string> Itens { get; }
    public DateTime Data { get; }
    public Pedido(Guid clienteId, List<string> itens, DateTime data)
    {
        if (clienteId == Guid.Empty)
            throw new ArgumentException("Cliente inválido.");

        if (itens is null || !itens.Any())
            throw new ArgumentException("Itens obrigatórios.");

        if (data == default)
            throw new ArgumentException("Data inválida.");

        ClienteId = clienteId;
        Itens = itens;
        Data = data;
    }
}