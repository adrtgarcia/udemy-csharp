Console.WriteLine("Conversão de Tipos\n");

int varInt1 = 100;
double varDouble1 = varInt1;            // conversão implícita (tipo menor > tipo maior)
Console.WriteLine(varDouble1);

double varDouble2 = 134.45;
int varInt2 = (int)varDouble2;          // conversão explícita (tipo maior > tipo menor): cast
Console.WriteLine(varInt2);

float resultado;
resultado = 10 / 4;
Console.WriteLine(resultado);
resultado = (float) 10 / 4;
Console.WriteLine(resultado);

int numInt = 123;
double numDouble = 12.45;
decimal numDecimal = 12.5678m;

string str1 = numInt.ToString();
string str2 = numDouble.ToString();
string str3 = numDecimal.ToString();
Console.WriteLine(str1 + " - " + str2 + " - " + str3);

/*
 
Classe Convert:
    ToBoolean(), ToChar(), ToDouble(), ToInt16(), ToInt32(), ToString()

 */

Console.WriteLine(Convert.ToChar(numInt));
Console.WriteLine(Convert.ToBoolean(numInt));
Console.WriteLine(Convert.ToInt32(numInt));

/*
 
OverflowException:
    Acontece quando uma conversão de estreitamento de dados resultar em perda de dados

    int varInt = 10000;
    Console.WriteLine(Convert.ToByte(varInt));

 */