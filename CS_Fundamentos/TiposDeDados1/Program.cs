Console.WriteLine("hello world");

/*
 
ATALHOS:
ctrl + f5 >> executa o código sem depuração
f5 >> executa o código com depuração
ctrl + k + d >> organiza o código
ctrl + d >> duplica a linha onde o cursor está
ctrl + f >> localiza algo no documento atual

*/

Console.WriteLine("Tipos de valor numéricos pré-definidos: Int e outros inteiros");

int valor1 = 123;
int valor2;
valor2 = 789;
const int valor3 = 456;

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);

/*
 
TIPOS DE REFERÊNCIA (memória heap) -> string, class, object, dynamic 
não armazenam dados diretamente, cada tem uma referência ao local da memória onde os dados estão armazenados

TIPOS DE VALOR (memória stack) -> tipos de dados numéricos e não numéricos
armazenam diretamente seus dados e cada variável tem uma cópia dos dados

*/
