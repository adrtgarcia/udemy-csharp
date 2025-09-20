Console.WriteLine("## Usando os métodos de TimeOnly ##");
Console.ReadLine();

var agora = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine($"\nTimeOnly.FromDateTime(DateTime.Now) => {agora.ToLongTimeString()}\n");

var futuro = agora.AddHours(1)
                  .AddMinutes(30)
                  .Add(TimeSpan.FromSeconds(45));

Console.WriteLine($"Incluindo 1 hora, 30 minutos e 45 segundos");
Console.WriteLine($"AddHours(1).AddMinutes(30).Add(TimeSpan.FromSeconds(45) : {futuro.ToLongTimeString()}\n");


Console.WriteLine("Subtraindo 10 minutos");
var hora1 = new TimeOnly(0,3);
Console.WriteLine($"TimeOnly(0,3) => {hora1}");
var novaHora1 = hora1.AddMinutes(-10);
Console.WriteLine($"AddMinutes(-10) => {novaHora1}\n");

Console.ReadLine();

Console.WriteLine($" --- Criando duas horas e comparando ---\n");
Console.ReadKey();
var hora2 = new TimeOnly(21, 12, 25);
var hora3 = TimeOnly.FromDateTime(DateTime.Now); //+> 03/12/2021

Console.WriteLine($"hora2 = {hora2}");
Console.WriteLine($"hora3 = {hora3}\n");

// compara=0 (igual) compara1<0 (anterior) compara1>0 (posterior)
var compara1 = hora2.CompareTo(hora3);
var compara2 = hora2.Equals(hora3);

Console.WriteLine($"{hora2} Comparada(CompareTo) com {hora3}  =>  {compara1}");
Console.WriteLine($"{hora2} É Igual(Equals) a {hora3}      =>  {compara2}\n");

Console.ReadLine();

var meianoite = new TimeOnly(0, 0);
var meiodia = new TimeOnly(12, 0);
var seishora = new TimeOnly(18, 0);
var horaAtual = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine("-- Verificando se uma hora esta em um intervalo --");

Console.WriteLine($"TimeOnly(0,0)  => {meianoite}");
Console.WriteLine($"TimeOnly(12,0) => {meiodia}");
Console.WriteLine($"TimeOnly(18,0) => {seishora}");
Console.WriteLine($"TimeOnly.FromDateTime(DateTime.Now) Hora Atual => {horaAtual}");

Console.ReadLine();
Console.WriteLine("### Resultado ###");

if (horaAtual.IsBetween(meianoite, meiodia))
    Console.WriteLine("Hora atual esta Antes do meio dia -> Bom dia");
else if(horaAtual.IsBetween(meiodia,seishora))
    Console.WriteLine("Hora atual esta Depois do meio dia -> Boa tarde");
else
    Console.WriteLine("Hora atual esta Depois das 18 horas -> Boa Noite");

Console.ReadLine();

Console.WriteLine("Calculando intervalo entre horas (TimeSpan)\n");

var inicio = new TimeOnly(10, 30); //10:30 AM
var termino = new TimeOnly(17, 20); //17:10 PM

Console.WriteLine($"TimeOnly(10,30)  Inicio => {inicio}");
Console.WriteLine($"TimeOnly(17,20)  Fim => {termino}\n");

TimeSpan diferenca = termino - inicio; //6 hora 50 minutos
Console.WriteLine("### Cálculo da diferença ###");
Console.WriteLine($" {termino} - {inicio}  = {diferenca}\n@");
Console.ReadLine();