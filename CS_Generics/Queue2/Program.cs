Console.WriteLine("Queue<T>");

Console.WriteLine("\nAdicionando pedidos na fila...");

Queue<Pedido> pedidos = new();
pedidos.Enqueue(new Pedido(1, 34.99));
pedidos.Enqueue(new Pedido(2, 85.50));
pedidos.Enqueue(new Pedido(3, 49.99));

Console.WriteLine($"Número de pedidos na fila: {pedidos.Count}");

while (pedidos.Count > 0)
{
    Pedido p = pedidos.Dequeue();
    Console.WriteLine($"\nPedido nº {p.Numero} sendo processado...");
    Console.WriteLine($"Pedido nº {p.Numero} - R$ {p.Valor.ToString("c")} foi processado");
    Console.WriteLine($"Número de pedidos na fila: {pedidos.Count}");
}

pedidos.Enqueue(new Pedido(4, 59.99));
pedidos.Enqueue(new Pedido(5, 42.50));
pedidos.Enqueue(new Pedido(6, 38.95));

Console.WriteLine("\nLocalizando pedido nº 5...");
int numeroPedido = 5;
Pedido? pedidoLocalizado = pedidos.FirstOrDefault(p => p.Numero == numeroPedido);
if (pedidoLocalizado != null)
    Console.WriteLine($"Pedido nº {pedidoLocalizado.Numero} - R$ {pedidoLocalizado.Valor.ToString("c")}");
else
    Console.WriteLine("Pedido não encontrado");
Console.WriteLine($"Número de pedidos na fila: {pedidos.Count}");

while (pedidos.Count > 0)
{
    Pedido p = pedidos.Dequeue();
    Console.WriteLine($"\nPedido nº {p.Numero} sendo processado...");
    Console.WriteLine($"Pedido nº {p.Numero} - R$ {p.Valor.ToString("c")} foi processado");
    Console.WriteLine($"Número de pedidos na fila: {pedidos.Count}");
}

public class Pedido
{
    public int Numero { get; set; }
    public double Valor { get; set; }
    public Pedido(int numero, double valor)
    {
        Numero = numero;
        Valor = valor;
    }
}
