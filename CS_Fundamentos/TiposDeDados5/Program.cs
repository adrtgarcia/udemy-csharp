Console.WriteLine("hello world");

/*
 
ATALHOS:
ctrl + f5 >> executa o código sem depuração
f5 >> executa o código com depuração
ctrl + k + d >> organiza o código
ctrl + d >> duplica a linha onde o cursor está
ctrl + f >> localiza algo no documento atual

*/

Console.WriteLine("Tipos de valor não-numéricos: Struct DateTime");

DateTime dataAtual = DateTime.Now;                              
Console.WriteLine(dataAtual);                                   // imprime no formato do sistema operacional

DateTime data1 = new DateTime(2025, 09, 02);                    // aaaa, mm, dd
Console.WriteLine(data1);

DateTime data2 = new DateTime(2025, 09, 02, 15, 55, 30);        // aaaa, mm, dd, hh, mm, ss
Console.WriteLine(data2);

/*

Operações possíveis com a Struct DateTime:
- extrair informações (Year, Month, Day, Hour, Minute, Second, Millisecond
- adicionar datas (AddDays, AddHours, AddMonths, AddYears)
- obter dia da semana e do ano (DayOfWeek, DayOfYear)
- expressar a data no formato longo e abreviado (ToLongDateString, ToShortDateString)
- expressar a hora no formato longo e abreviado (ToLongTimeString, ToShortTimeString)
 
*/

Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.AddMonths(15));
Console.WriteLine(dataAtual.ToLongDateString());
Console.WriteLine(dataAtual.ToShortDateString());
Console.WriteLine(dataAtual.ToLongTimeString());
Console.WriteLine(dataAtual.ToShortTimeString());
Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.DayOfYear);

/*
 
TIPOS DE REFERÊNCIA (memória heap) -> string, class, object, dynamic 
não armazenam dados diretamente, cada tem uma referência ao local da memória onde os dados estão armazenados

TIPOS DE VALOR (memória stack) -> tipos de dados numéricos e não numéricos
armazenam diretamente seus dados e cada variável tem uma cópia dos dados

*/
