Console.WriteLine("Delegate Pré-Definido: EventHandler<TEventArgs");

/*
 
    EventHandler<TEventArgs>: representa um método que vai manipular um evento que possui dados
        public delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e);
 
    - TEventArgs: o tipo de dados do evento gerado pelo evento
    - object? sender: contém uma referência ao objeto que gerou o evento
    - e TEventArgs: um objeto que contém os dados de um evento
 
    para passar os dados no segundo parâmetro do manipulador de eventos do publicador para os assinantes,
    temos que definir uma classe que herda da classe EventArgs e armazenar os dados que desejamos passar
    na classe
        * realizar os ajustes relativos a assinatura do delegate e dos métodos para enviar os dados

 */

Console.WriteLine("\nUsando o evento OnCriarPedido");

var pedido = new Pedido();

Console.WriteLine("\nAdicionando os subscribers...");
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += Sms.Enviar;
Console.WriteLine("Subscribers adicionados");

Console.WriteLine("\nChamando o método CriarPedido()");
pedido.CriarPedido("maria@email.com", "1234-5678");

public class PedidoEventArgs : EventArgs
{
    public string? Email { get; set; }
    public string? Telefone { get; set; }
}

public class Pedido
{
    public event EventHandler<PedidoEventArgs>? OnCriarPedido;
    public void CriarPedido(string email, string telefone)
    {
        Console.WriteLine("\nPedido criado");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, new PedidoEventArgs { Email = email, Telefone = telefone} );
        }
    }
}

public class Email
{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Enviando um email para: {e.Email}");
    }
}

public class Sms
{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Enviando um SMS para: {e.Telefone}");
    }
}
