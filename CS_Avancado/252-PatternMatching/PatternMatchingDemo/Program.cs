Console.WriteLine("\nPattern Matching com is e switch\n");

var entregas = new Entrega[]
{
    new RetiradaNaLoja(),
    new EntregaExpressa(15),
    new EntregaExpressa(35),
    new EntregaAgendada(DateTime.Today.AddDays(1)), // dia da semana vai variar
    new EntregaAgendada(new DateTime(2025, 5, 25))  // domingo
};

foreach (var entrega in entregas)
{
    var valor = CalcularFrete(entrega);
    Console.WriteLine($"{entrega,-60} -> Frete: R$ {valor:N2}");
}


Console.ReadKey();
static decimal CalcularFrete(Entrega entrega) =>
  entrega switch
  {
      RetiradaNaLoja => 0m,
      EntregaExpressa(var km) when km < 20 => 15m,
      EntregaExpressa(var km) => 25m + (decimal)(km - 20) * 1.5m,
      EntregaAgendada { DataAgendada: var data } when data.DayOfWeek == DayOfWeek.Sunday => 50m,
      EntregaAgendada => 20m,
      _ => throw new ArgumentException("Tipo de entrega desconhecido.")
  };
public abstract record Entrega;
public record RetiradaNaLoja() : Entrega;
public record EntregaExpressa(double DistanciaKm) :Entrega;
//public record EntregaAgendada(DateTime DataAgendada) : Entrega;
public record EntregaAgendada(DateTime DataAgendada) : Entrega
{
    public override string ToString() =>
        $"Entrega Agendada (Data: {DataAgendada:dddd, dd MMM yyyy})";
}
