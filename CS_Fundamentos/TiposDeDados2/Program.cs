Console.WriteLine("hello world");

/*
 
ATALHOS:
ctrl + f5 >> executa o código sem depuração
f5 >> executa o código com depuração
ctrl + k + d >> organiza o código
ctrl + d >> duplica a linha onde o cursor está
ctrl + f >> localiza algo no documento atual

*/

Console.WriteLine("Tipos de valor numéricos pré-definidos: Double, Float, Decimal");

double valor1 = 1.25;       // não precisa, mas pode ter d no final
float valor2 = 2.68f;       // precisa colocar f no final
decimal valor3 = 3.74m;     // precisa colocar m no final

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);

Console.WriteLine("Comparando a precisão");

float y = 1f / 3;
double x = 1d / 3d;
decimal z = 1m / 3m;

Console.WriteLine("float: " + y);
Console.WriteLine("double: " + x);
Console.WriteLine("decimal: " + z);

/*
 
TIPOS DE REFERÊNCIA (memória heap) -> string, class, object, dynamic 
não armazenam dados diretamente, cada tem uma referência ao local da memória onde os dados estão armazenados

TIPOS DE VALOR (memória stack) -> tipos de dados numéricos e não numéricos
armazenam diretamente seus dados e cada variável tem uma cópia dos dados

*/
