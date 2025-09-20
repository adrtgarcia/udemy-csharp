Console.WriteLine("## TimeOnly - Operadores ##\n");
Console.ReadKey();

Console.WriteLine("Criando duas instâncias de TimeOnly\n");
TimeOnly hora1 = TimeOnly.FromDateTime(DateTime.Now);
TimeOnly hora2 = TimeOnly.Parse("15:35");

Console.WriteLine($"hora1 = {hora1}");
Console.WriteLine($"hora2 = {hora2}\n");

Console.WriteLine("Usando os operadores de TimeOnly\n");
Console.ReadKey();

var igualdade = hora1 == hora2;
Console.WriteLine($"{hora1} == {hora2}  => {igualdade}\n");

var maiorque = hora1 > hora2;
Console.WriteLine($"{hora1} > {hora2}  => {maiorque}\n");

var maiorqueouigual = hora1 >= hora2;
Console.WriteLine($"{hora1} >= {hora2}  => {maiorqueouigual}\n");

var diferente = hora1 != hora2;
Console.WriteLine($"{hora1} != {hora2}  => {diferente}\n");

var menorque = hora1 < hora2;
Console.WriteLine($"{hora1} < {hora2}  => {menorque}\n");

var menorqueouigual = hora1 <= hora2;
Console.WriteLine($"{hora1} <= {hora2}  => {menorqueouigual}\n");

Console.ReadKey();

TimeOnly meiodia = new (12, 0);

var agora = TimeOnly.FromDateTime(DateTime.Now);

if (agora < meiodia)
    Console.WriteLine("\nBom dia!");

Console.ReadKey();
