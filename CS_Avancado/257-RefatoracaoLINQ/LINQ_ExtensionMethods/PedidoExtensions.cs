
public static class PedidoExtensions
{
    public static IEnumerable<Pedido> ApenasAprovados(this IEnumerable<Pedido> pedidos) =>
    pedidos.Where(p => p.Status == StatusPedido.Aprovado);

    public static IEnumerable<Pedido> ApenasClientesEspeciais(this IEnumerable<Pedido>
     pedidos) => pedidos.Where(p => p.TipoCliente == TipoCliente.Vip ||
                               p.TipoCliente == TipoCliente.Premium ||
                               p.TipoCliente == TipoCliente.Platinum);

    public static IEnumerable<Pedido> ComValorMinimo(this IEnumerable<Pedido> pedidos,
                                                 decimal minimo) =>
    pedidos.Where(p => p.Total >= minimo);

    public static IEnumerable<Pedido> OrdenadosPorValorDecrescente(this IEnumerable<Pedido>
    pedidos) => pedidos.OrderByDescending(p => p.Total);
}

