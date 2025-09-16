Console.WriteLine("Delegate Pré-Definido: EventHandler");

/*
 
    EventHandler: representa um método que vai manipular um evento que não possui dados
         public delegate void EventHandler(object? sender, EventArgs e);
    
    - object? sender: contém uma referência ao objeto que gerou o evento
    - e EventArgs: um objeto que não contém nenhum dado de um evento
  
 */

Console.WriteLine("\nUsando o evento OnCriarPedido");

var pedido = new Pedido();

Console.WriteLine("\nAdicionando os subscribers...");
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += Sms.Enviar;
Console.WriteLine("Subscribers adicionados");

Console.WriteLine("\nChamando o método CriarPedido()");
pedido.CriarPedido();

/* public delegate void PedidoEventHandler();      <- será substituído pelo EventHandler */

public class Pedido
{
    public event EventHandler? OnCriarPedido;
    public void CriarPedido()
    {
        Console.WriteLine("\nPedido criado");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, EventArgs.Empty);
        }
    }
}

public class Email
{
    public static void Enviar(object? sender, EventArgs e)
    {
        Console.WriteLine("Enviando um email");
    }
}

public class Sms
{
    public static void Enviar(object? sender, EventArgs e)
    {
        Console.WriteLine("Enviando um SMS");
    }
}
