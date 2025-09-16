Console.WriteLine("Eventos");

/*
    
    EVENTOS são mecanismos que permitem que uma classe ou objeto notifique outras classes ou objetos
    quando alguma ação ocorre
        - publisher: classe que envia/aciona o evento
        - subscribers: classes que recebem/manipulam os eventos 

    criando um evento:
        1) definir um delegate com a assinatura do método que será chamado quando o evento for disparado
        2) declarar um evento na classe que irá disparar o evento, usando o delegate definido
        3) disparar o evento quando a ação desejada ocorrer na classe
        4) inscrever os assinantes interessados nos eventos desejados

 */

Console.WriteLine("\nUsando o evento OnCriarPedido");

var pedido = new Pedido();

Console.WriteLine("\nAdicionando os subscribers...");
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += Sms.Enviar;
Console.WriteLine("Subscribers adicionados");

Console.WriteLine("\nChamando o método CriarPedido()");
pedido.CriarPedido();

public delegate void PedidoEventHandler();

public class Pedido
{
    public event PedidoEventHandler? OnCriarPedido;
    public void CriarPedido()
    {
        Console.WriteLine("\nPedido criado");
        
        /* 
        
        forte acoplamento, Pedido depende das outras classes
        -> se quiser fazer outras tarefas, terá que modificar o método
        
        Email.Enviar();
        Sms.Enviar();

        -> solução: Pedido vira publisher, Email e Sms viram subscribers

        */

        if (OnCriarPedido != null)
        {
            OnCriarPedido();
        }
    }
}

public class Email
{
    public static void Enviar()
    {
        Console.WriteLine("Enviando um email");
    }
}

public class Sms
{
    public static void Enviar()
    {
        Console.WriteLine("Enviando um SMS");
    }
}
