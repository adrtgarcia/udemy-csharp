
public static class PedidoService
{
    public static List<Pedido> ObterPedidos()
    {
        return new List<Pedido>
        {
            new Pedido { Id = 1, Cliente = "João", TipoCliente = TipoCliente.Vip, Status = StatusPedido.Aprovado, Total = 250 },
            new Pedido { Id = 2, Cliente = "Maria", TipoCliente = TipoCliente.Standard, Status = StatusPedido.Aprovado, Total = 300 },
            new Pedido { Id = 3, Cliente = "Carlos", TipoCliente = TipoCliente.Premium, Status = StatusPedido.Aprovado, Total = 500 },
            new Pedido { Id = 4, Cliente = "Ana", TipoCliente = TipoCliente.Vip, Status = StatusPedido.Pendente, Total = 400 },
            new Pedido { Id = 5, Cliente = "Paula", TipoCliente = TipoCliente.Platinum, Status = StatusPedido.Aprovado, Total = 700 }
        };
    }
}