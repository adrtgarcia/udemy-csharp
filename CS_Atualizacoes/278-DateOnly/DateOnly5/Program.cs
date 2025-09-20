Console.WriteLine("## DateOnly - Operadores ##\n");
Console.ReadKey();

Console.WriteLine("Criando instância de duas datas\n");
DateOnly data1 = new DateOnly(1939, 9, 1);
DateOnly data2 = new DateOnly(1945, 9, 2);

Console.WriteLine($"data1 = {data1}");
Console.WriteLine($"data2 = {data2}\n");

Console.WriteLine("Usando os operadores de DateOnly\n");
Console.ReadKey();

var igualdade = data1 == data2;
Console.WriteLine($"{data1} == {data2}  => {igualdade}\n");

var maiorque = data1 > data2;
Console.WriteLine($"{data1} > {data2}  => {maiorque}\n");

var maiorqueouigual = data1 >= data2;
Console.WriteLine($"{data1} >= {data2}  => {maiorqueouigual}\n");

var diferente = data1 != data2;
Console.WriteLine($"{data1} != {data2}  => {diferente}\n");

var menorque = data1 < data2;
Console.WriteLine($"{data1} < {data2}  => {menorque}\n");

var menorqueouigual = data1 <= data2;
Console.WriteLine($"{data1} <= {data2}  => {menorqueouigual}\n");

Console.ReadKey();






