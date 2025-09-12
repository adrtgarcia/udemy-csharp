/*
 
ATALHOS:
ctrl + f5 >> executa o código sem depuração
f5 >> executa o código com depuração
ctrl + k + d >> organiza o código
ctrl + d >> duplica a linha onde o cursor está
ctrl + f >> localiza algo no documento atual

*/

// EX01
string nome = "Paulo";
int idade = 17;
double nota = 7.5;

Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota);
Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");

// EX02
Console.WriteLine("\nAluno " + nome + "\ntem " + idade + "anos \ne nota " + nota);
Console.WriteLine($"Aluno {nome} \ntem {idade} anos \ne nota {nota}");

// EX03
Console.WriteLine("\nDouble e decimal");

// EX04
Console.WriteLine("\nDouble > Long, Double > Float, Decimal > Float, Long > Int, Double > Decimal");

// EX05
Console.WriteLine("\nInsira uma letra: ");
char letra1 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Insira uma letra: ");
char letra2 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Insira uma letra: ");
char letra3 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("\n" + letra3 + letra2 + letra1);
Console.WriteLine($"{letra3}{letra2}{letra1}");


/*
 
EX06

    (F)     long resultado = 1.32;
    (V)     var nome = “Maria”;
    (V)     string resultado = 100.ToString();
    (V)     A sequência de escape \n inclui uma nova linha
    (F)     float f = 5.45;
    (V)     decimal valor = (decimal) 10.99f;
    (F)     var status = null;
    (V)     object o = 12.45m;
    (V)     string titulo = true.ToString();
    (F)     A sequencia \t inclui uma tabulação vertical
 
 */

// EX07
Console.WriteLine("\nInforme o primeiro número: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o segundo número: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"\n{num1} + {num2} = {num1 + num2}");
Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
Console.WriteLine($"{num1} ^ {num2} = {Math.Pow(num1, num2)}");
Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
Console.WriteLine($"{num1} % {num2} = {num1 % num2}");

// EX08
int a = 1, b = 12, c = -13;
double x1 = ((-b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)))/(2 * a); 
double x2 = ((-b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)))/(2 * a);
Console.WriteLine($"\nx1 = {x1}, x2= {x2}");


// EX09
Console.WriteLine("\nInforme o nome: ");
nome = Console.ReadLine();
Console.WriteLine("Informe a senha: ");
int senha = Convert.ToInt32(Console.ReadLine());

var login = (nome == "admin" || nome == "maria") && (senha == 123) ? "Login feito com sucesso" : "Login inválido";
Console.WriteLine(login);

/*
 
EX10

    (V)     string? nome; é um exemplo de nullable reference type;
    (F)     para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
    (F)     A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
    (V)     para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
    (F)     (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
    (F)     Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
    (V)     Os nullable reference types emitem um alerta em tempo de compilação para uso do null
    (F)     Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
    (F)     Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
    (V)     O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
    (V)     Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"

 */

// EX11
Console.WriteLine("\nInforme o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((x % 2 == 0) ? "x é par" : "x é ímpar");
Console.WriteLine((y % 2 == 0) ? "y é par" : "y é ímpar");


// EX12
Console.WriteLine("\nInforme o valor de x: ");
x = Convert.ToInt32(Console.ReadLine());
const double PI = 3.1415;

Console.WriteLine($"-6 * x * 5 = {-6 * x * 5}");
Console.WriteLine($"(13 - 2) * x = {(13 - 2) * x}");
Console.WriteLine($"(x + -2) * (20 / x) = {(x + -2) * (20 / x)}");
Console.WriteLine($"(12 + x) / (x - 4) = {(12 + x) / (x - 4)}");
Console.WriteLine($"3 * x^2 + x + 10 = {3 * (Math.Pow(x, 2)) + x + 10}");
Console.WriteLine($"pi * x^2 = {PI * Math.Pow(x, 2)}");

// EX13
y = 5;
Console.WriteLine($"\n(y++) + y + (++y) = {(y++)+y+(++y)}");
y = (y++) + y + (++y);
Console.WriteLine(y);

y = 5;
Console.WriteLine($"\ny++ + y + ++y = {y++ + y + ++y}");
y = y++ + y + ++y;
Console.WriteLine(y);

// EX14
Console.WriteLine("\nInforme a temperatura (ºC): ");
double celsius = Convert.ToDouble(Console.ReadLine());
double kelvin = celsius + 273;
double farhenheit = ((celsius * 9) / 5) + 32;
Console.WriteLine($"{celsius} ºC = {kelvin} K = {farhenheit} ºF");

// EX15
var numero = 5;
Console.WriteLine(numero++);        // 5
numero = 1;
Console.WriteLine(++numero);        // 2 
numero = 2;
Console.WriteLine(numero--);        // 2
numero = 3;
Console.WriteLine(--numero);        // 2

