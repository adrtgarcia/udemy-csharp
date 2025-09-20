
var pedidoInvalido = new Pedido(Guid.Empty, new(), default);

public class Pedido(Guid clienteId, List<string> itens, DateTime data)
{
    public Guid ClienteId { get; } = clienteId != Guid.Empty
        ? clienteId
        : throw new ArgumentException("Cliente inválido.");

    public List<string> Itens { get; } = itens is { Count: > 0 }
        ? itens
        : throw new ArgumentException("Itens obrigatórios.");

    public DateTime Data { get; } = data != default
        ? data
        : throw new ArgumentException("Data inválida.");
}