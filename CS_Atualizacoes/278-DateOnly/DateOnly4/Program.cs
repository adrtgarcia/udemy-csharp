Console.WriteLine("### NET 6 - Usando DateOnly ###\n");

Console.WriteLine("Informe a data de nascimento");

Console.WriteLine("Informe o dia (dd) : ");
var dia = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Informe o mês (mm) : ");
var mes = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Informe o ano (aaaa) : ");
var ano = Convert.ToInt16(Console.ReadLine());

var dataAniversario = new DateOnly(ano, mes, dia);
Console.WriteLine($"\nVocê nasceu em : {dataAniversario}");

var dataAtual = DateOnly.FromDateTime(DateTime.Now);

var numeroDias = dataAtual.DayNumber - dataAniversario.DayNumber;
Console.WriteLine($"Parabéns você já viveu {numeroDias} dias");

var idade = (numeroDias / 365);
Console.WriteLine($"Sua idade aproximada é {idade} anos");

Console.ReadKey();