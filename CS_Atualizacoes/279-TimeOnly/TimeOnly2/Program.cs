Console.WriteLine("## Usando as propriedades de TimeOnly ##");
Console.ReadLine();

var hora1 = new TimeOnly(2, 30, 50);
Console.WriteLine($"\nTimeOnly(2,30,50) => {hora1.ToLongTimeString()}\n");

Console.WriteLine("-- Hour - Minute - Second --");
Console.WriteLine($"TimeOnly.Hour     = {hora1.Hour}  ");
Console.WriteLine($"TimeOnly.Minute   = {hora1.Minute}");
Console.WriteLine($"TimeOnly.Second   = {hora1.Second}\n");

Console.ReadLine();

var agora = TimeOnly.FromDateTime(DateTime.Now);
long ticks = agora.Ticks;

Console.WriteLine("-- Obtendo o número de ticks --");
Console.WriteLine($"Hora Atual possui : {ticks} ticks\n");

long ticks1 = 463_000_000_000;
var horaTicks = new TimeOnly(ticks1);

Console.WriteLine("-- Convertendo ticks para horas --");
Console.WriteLine($"463_000_000_000 ticks representa : {horaTicks} \n@");

Console.ReadLine();
