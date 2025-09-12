using System.Security.Cryptography;

Console.WriteLine("\nOperadores aritméticos (+ - * / %)\n");

Console.WriteLine($"1 + 2 = {1 + 2}");
Console.WriteLine($"5 - 2 = {5 - 2}");
Console.WriteLine($"3 * 4 = {3 * 4}");
Console.WriteLine($"7 / 7 = {7 / 7}");
Console.WriteLine($"5 % 2 = {5 % 2}");

/*
 
Classe Math:
    Math.PI, Math.E, Cos(x), Sin(x), Tan(x), Sqrt(x), Pow(x, y),
    Abs(x), Max(x, y), Min(x, y), Log10(x), Log(x), Exp(x)

 */


Console.WriteLine("\nInferência de tipos (var)\n");

/*
 
VAR permite a definição implícita/indireta do tipo de dados de uma variável.
* o compilador vai se basear no valor atribuído a ela para inferir seu tipo.
   
    var x = 1; 
    var nome = "maria";

observações importantes:
* uma variável var sempre deve ser inicializada junto à declaração
* não é possível inicializar como null
* múltiplas variáveis var não podem ser inicializadas na mesma instrução
* não é possível alterar o valor de uma variável var depois de inicializada

é um sugar syntax, usado para declarar tipos anônimos, para laços for e foreach e instruções using
 
 */

var nome = "Maria";
var idade = 25;
var salario = 2500.00;
Console.WriteLine($"{nome} tem {idade} anos e recebe {salario.ToString("c")}");


Console.WriteLine("\nOperadores de atribuição (+= -= *= /= %=)\n");

var x = 10;
Console.WriteLine("x = 10");
Console.WriteLine($"x += 5 -> {x += 5}");
Console.WriteLine($"x -= 3 -> {x -= 3}");
Console.WriteLine($"x *= 4 -> {x *= 4}");
Console.WriteLine($"x /= 5 -> {x /= 5}");
Console.WriteLine($"x %= 5 -> {x %= 5}");

var y = "123";
Console.WriteLine("y = \"123\"");
Console.WriteLine($"y += \"456\" -> {y += "456"}");
Console.WriteLine($"y + \"789\" -> {y + "789"}");
Console.WriteLine($"y + 012 -> {y + 012}");


Console.WriteLine("\nOperadores de incremento e decremento (++ --)\n");

int z = 3, resultado;
Console.WriteLine("z = 3");
Console.WriteLine($"z++ = {z++}, ++z = {++z}");
Console.WriteLine($"z-- = {z--}, --z = {--z}");

z = 3;
resultado = 0;
Console.WriteLine($"\nz = {z}, resultado = {resultado}");

resultado = z++ + 10;
Console.WriteLine($"z++ + 10 ===> z = {z}, resultado = {resultado}");

resultado = ++z + 10;
Console.WriteLine($"++z + 10 ==> z = {z}, resultado = {resultado}");

resultado = z-- + 5;
Console.WriteLine($"z-- + 5 ==> z = {z}, resultado = {resultado}");

resultado = --z + 5;
Console.WriteLine($"--z + 5 ==> z = {z}, resultado = {resultado}");


Console.WriteLine("\nOperadores relacionais (== > < >= <= !=)\n");

Console.WriteLine($"1 == 2? {1 == 2}");
Console.WriteLine($"5 > 2? {5 > 2}");
Console.WriteLine($"3 <= 4? {3 <= 4}");
Console.WriteLine($"7 != 7? {7 != 7}");

Console.WriteLine("\n== é o único que se pode usar com strings:");
string str1 = "abc", str2 = "Abc";
Console.WriteLine($"{str1} == {str2}? {str1 == str2}");
Console.WriteLine($"str1.Equals(str2) = {str1.Equals(str2)}");


Console.WriteLine("\nOperadores lógicos (&& || !)\n");
Console.WriteLine($"true && true = {true && true}");
Console.WriteLine($"true && false = {true && false}");
Console.WriteLine($"false && false = {false && false}");
Console.WriteLine($"\ntrue || true = {true || true}");
Console.WriteLine($"true || false = {true || false}");
Console.WriteLine($"false || false = {false || false}");
Console.WriteLine($"\n!true = {!true}");
Console.WriteLine($"!false = {!false}");


Console.WriteLine("Nullable Reference Types");

/*
 
para inibir o alerta de NullReferenceException, podemos usar o tipo Nullable(?) ao atribuir o valor null
* ao acessar a referência, usamos o Null Conditional Operator (?.)

 */

/*
 
Não fazer (há lançamento de excessão):
    string nomeCompleto = null;                 
    Console.WriteLine(nomeCompleto.ToUpper());   

Ou ainda:
    string? nomeCompleto = null;                     
    Console.WriteLine(nomeCompleto.ToUpper());      // "nomeCompleto may be null here" (lança exceção)
 
 */

string? nomeCompleto = null;                        // boa prática: sempre declarar como nullable 
Console.WriteLine(nomeCompleto?.ToUpper());         // se a variável for null, o método não é chamado (não há lançamento de exceção) e imprime null

string sobrenome = "";                              // outra opção é iniciar a variável corretamente
Console.WriteLine(sobrenome?.ToUpper());    


Console.WriteLine("\nOperador ternário\n");

/*
 
Lista de operadores:

    Operador unário + não tem efeito na expressão, retorna o valor do seu operando
    Operador unário - produz o negativo do seu operando
    Operador condicional ternário ?: avalia uma expressão booleana e retorna o resultado de uma, das duas, expressões

 */

int numero = 9;
Console.WriteLine($"+{numero} = {+numero}");
Console.WriteLine($"-{numero} = {-numero}");

// condição ? expressao_true : expressao_false
var valor = (9 % 2 == 0) ? "é par" : "é ímpar";
Console.WriteLine($"{numero} {valor}");

int a = 7, b = 9;
var comparacao = a > b ? "a é maior que b" :
                 a < b ? "a é menor que b" :
                 a == b ? "a é igual a b" : "sem resultado";
Console.WriteLine($"Comparando a = {a} e b = {b}, {comparacao}");