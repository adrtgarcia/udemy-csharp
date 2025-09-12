Console.WriteLine("hello world");

/*
 
ATALHOS:
ctrl + f5 >> executa o código sem depuração
f5 >> executa o código com depuração
ctrl + k + d >> organiza o código
ctrl + d >> duplica a linha onde o cursor está
ctrl + f >> localiza algo no documento atual

*/

Console.WriteLine("Tipos de valor não-numéricos pré-definidos: Bool, Char");

bool estaLigado = true;
bool estaAtivo = false;

Console.WriteLine(estaLigado);
Console.WriteLine(estaAtivo);

Console.WriteLine(10 == 15);
Console.WriteLine(10 == 10);

int x = 10, y = 15;
Console.WriteLine(x > y);
Console.WriteLine(x < y);

char letra1 = 'A';
char letra2 = '\u0041';
char letra3 = 'b';

Console.WriteLine(letra1);
Console.WriteLine(letra2);
Console.WriteLine(letra3);

/*
 
TIPOS DE REFERÊNCIA (memória heap) -> string, class, object, dynamic 
não armazenam dados diretamente, cada tem uma referência ao local da memória onde os dados estão armazenados

TIPOS DE VALOR (memória stack) -> tipos de dados numéricos e não numéricos
armazenam diretamente seus dados e cada variável tem uma cópia dos dados

*/
