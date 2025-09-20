Console.WriteLine("## DateOnly - Propriedades ##");
Console.ReadKey();

Console.WriteLine("Criando instância de duas datas\n");
DateOnly data1 = new DateOnly(2021, 11, 26);
DateOnly data2 = new DateOnly(1945, 9, 2);

Console.WriteLine($"data1 = {data1}");
Console.WriteLine($"data2 = {data2}\n");

Console.WriteLine("### Usando as propriedades de DateOnly ###\n");
Console.ReadKey();

Console.WriteLine($"Year      = {data1.Year}");         
Console.WriteLine($"Month     = {data1.Month}");        
Console.WriteLine($"Day       = {data1.Day}");          
Console.WriteLine($"DayOfWeek = {data1.DayOfWeek}");    
Console.WriteLine($"DayOfYear = {data1.DayOfYear}\n");    

Console.WriteLine($"Número de dias data1 = {data1.DayNumber}");
Console.WriteLine($"Número de dias data2 = {data2.DayNumber}\n");

Console.WriteLine("### Calculando a diferença entre data1 e data2 ###\n");
Console.ReadKey();

//numero de dias entre duas datas
var numeroDias = data1.DayNumber - data2.DayNumber;
Console.WriteLine($"Diferença em dias entre {data1} e {data2} = {numeroDias} dias");

//numero de anos
var resultado = (numeroDias / 365);
Console.WriteLine($"Diferença em anos entre {data1} e {data2} = {resultado} anos");

Console.ReadKey();
