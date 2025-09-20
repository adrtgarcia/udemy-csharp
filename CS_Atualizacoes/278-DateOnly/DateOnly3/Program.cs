Console.WriteLine("## DateOnly - Métodos ##\n");
Console.ReadKey();

var natal = new DateOnly(2021, 12, 25);

Console.WriteLine($"\nNatal de 2021 : {natal}");
Console.WriteLine($"\nIncluindo 1 dia, 1 mês e 1 ano a {natal}\n");
Console.ReadKey();

var novaData = natal.AddDays(1).AddMonths(1).AddYears(1);
Console.WriteLine($"Nova data obtida : {novaData}");

Console.WriteLine($"\nCriando duas datas e comparando \n");
Console.ReadKey();
var data1 = new DateOnly(2021, 11, 25);
var data2 = DateOnly.FromDateTime(DateTime.Now); //+> 26/11/2021

Console.WriteLine($"data1 = {data1}");
Console.WriteLine($"data2 = {data2}\n");

// compara=0 (igual) compara1<0 (anterior) compara1>0 (posterior)
var compara1 = data1.CompareTo(data2);
var compara2 = data1.Equals(data2);

Console.WriteLine($"{data1} Comparada com {data2}  =>  {compara1}");
Console.WriteLine($"{data1} É Igual a {data2}      =>  {compara2}\n");

Console.WriteLine("Usando o formato longo e curto para as datas e criando uma data com horas\n");
Console.ReadKey();

var longo = data1.ToLongDateString();
var curto = data2.ToShortDateString();
var datahora = data1.ToDateTime(new TimeOnly(10,30));

Console.WriteLine($"ToLongDateString()       = {longo}");
Console.WriteLine($"ToShortDateString()      = {curto}");
Console.WriteLine($"ToDateTime()             = {datahora}");

var igual = data1.Equals(data2);
Console.WriteLine($"{data1} Equals {data2} ? = {igual}");

Console.ReadKey();

