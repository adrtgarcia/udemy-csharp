using System.Globalization;

Console.WriteLine("##  C# 10  ##\n");

DateOnly dateOnly = new DateOnly();
Console.WriteLine($"DateOnly valor padrão : {dateOnly}\n");  //=> 01/01/0001
Console.ReadKey();

Console.WriteLine("###  Criando Datas com DateOnly ###\n");
Console.WriteLine("1- Usando o Construtor\n");
var anonovo_ocidente = new DateOnly(2022, 1, 1);

var persianCalendar = new PersianCalendar();
var japaneseCalendar = new JapaneseCalendar();
var anonovo_persia = new DateOnly(2022, 1, 1, persianCalendar );
var anonovo_oriente = new DateOnly(2022, 1, 1, japaneseCalendar);

Console.WriteLine($"Usando a cultura padrão : {anonovo_ocidente}");
Console.WriteLine($"Calendario Persia       : {anonovo_persia}");
Console.WriteLine($"Calendario Japonês      : {anonovo_oriente}");

Console.WriteLine("\n2- Usando :  FromDateTime , FromDayNumber e ParseExact \n");

DateOnly hoje = DateOnly.FromDateTime(DateTime.Now);
DateOnly data3 = DateOnly.FromDayNumber(738119);
var anonovo = DateOnly.Parse("01/01/2022");
var natal = DateOnly.ParseExact("25-12-2021", "dd-MM-yyyy");

Console.WriteLine($"FromDateTime   => hoje = {hoje}");
Console.WriteLine($"FromDayNumber  => 738119 dias = {data3}");
Console.WriteLine($"Parse          => Ano Novo : {anonovo}");
Console.WriteLine($"ParseExact     => Natal : {natal}");

Console.ReadKey();