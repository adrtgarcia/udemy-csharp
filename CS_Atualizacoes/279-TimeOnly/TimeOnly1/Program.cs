Console.WriteLine("## Usando TimeOnly ##\n");
TimeOnly timeonly = new TimeOnly();
Console.WriteLine($"new TimeOnly()      =>  {timeonly}");

Console.ReadLine();
Console.WriteLine("### Criando horas usando os construtores  ###\n");

var inicio = new TimeOnly(8,0 );
var fim = new TimeOnly(18,30 );
var horaCompleta = new TimeOnly(20,30,50);

Console.WriteLine($"TimeOnly(8,0)   {inicio}");
Console.WriteLine($"TimeOnly(18,30) {fim}   ");
Console.WriteLine($"TimeOnly(20,30,50) {horaCompleta.ToLongTimeString()}\n");

Console.WriteLine("### Parse - FromDateTime - FromTimeSpan - ToTimeSpan ###");

Console.ReadLine();

var almoco = TimeOnly.Parse("11:25");
var jantar = TimeOnly.Parse("19:45");
Console.WriteLine($"TimeOnly.Parse('11:25') almoco : {almoco}");
Console.WriteLine($"TimeOnly.Parse('19:45') jantar : {jantar}\n");

var agora = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine($"FromDateTime(DateTime.Now) agora : {agora}\n");

var horas = TimeSpan.FromHours(21);
var horas_timespan = TimeOnly.FromTimeSpan(horas);
Console.WriteLine($"TimeSpan.FromHours(21) : {horas_timespan}");

var minutos = TimeSpan.FromMinutes(10);
var minutos_timespan = TimeOnly.FromTimeSpan(minutos);
Console.WriteLine($"TimeSpan.FromMinutes(10) : {minutos_timespan}");

var segundos = TimeSpan.FromSeconds(45);
var segundos_timespan = TimeOnly.FromTimeSpan(segundos);
Console.WriteLine($"TimeSpan.FromSeconds(45) : {segundos_timespan.ToLongTimeString()}");

Console.WriteLine("\n--- Convertendo de TimeOnly para TimeSpan --");
long ticks = 863_999_999_999;
var temp = new TimeOnly(ticks);
TimeSpan ts = temp.ToTimeSpan();
Console.WriteLine($"\nDe TimeOnly('863_999_999_999') para ToTimeSpan {ts}\n@");

Console.ReadLine();