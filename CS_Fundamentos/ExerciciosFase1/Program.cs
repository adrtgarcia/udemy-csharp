/*
 
ATALHOS:
ctrl + f5 >> executa o código sem depuração
f5 >> executa o código com depuração
ctrl + k + d >> organiza o código
ctrl + d >> duplica a linha onde o cursor está
ctrl + f >> localiza algo no documento atual

*/

// EX01
int idade = 25;
Console.WriteLine(idade);

// EX02
string nome = "Maria";
Console.WriteLine(nome);

// EX03
double altura = 3.45;
Console.WriteLine(altura);

// EX04
DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine(data);

// EX05
const int ANO = 12;
Console.WriteLine(ANO);

// EX06
double? nota = 7.80;
Console.WriteLine(nota);

// EX07
Console.WriteLine("znTIPOS POR VALOR (numéricos e não-numéricos): Armazenados na memória stack, armazenam dados diretamente onde cada variável tem uma cópia própria dos dados");
Console.WriteLine("znTIPOS POR REFERÊNCIA (string, class, object, dynamic): Armazenados na memória heap, não armazenam dados diretamente e cada variável tem uma referência ao local da memória onde os dados estão armazenados");

/* 

EX08

    int x = 10;
    double numero = 7.99;
    char letra = 'C';
    float temperatura = 27.4f;
    bool ativo = false;
    string nome = "Manoel";
    decimal salario = 950.99m;
    DateTime hoje = DateTime.Now;

 */

/*
 
EX09

    int n = 1;                          tipo de valor
    string titulo = "A Vida";           tipo de referência
    float f = 12.45f;                   tipo de valor
    double d = 5.45;                    tipo de valor
    decimal valor = 10.99m;             tipo de valor
    char sexo = 'M';                    tipo de valor
    object o = null;                    tipo de referência

 */

// EX10
Console.WriteLine("\nNullable Type é um tipo de variável que pode receber um valor null, usado para representar um valor indefinido/ausente para um tipo de valor ou para tratar com valores null em cenários onde podemos ter ou não valores atribuídos como informações de um banco de dados.");

// EX11
Console.WriteLine("\nCamel Case é uma convenção de nomenclatura onde as palavras compostas são escritas juntas, todas começando com letra maiúscula, exceto a primeira delas (ex: nomeCompleto, senhaUsuario).");

// EX12
Console.WriteLine("\nPascal Case é uma convenção de nomenclatura onde as palavras compostas são escritas juntas, todas começando com letra maiúscula (ex: ContaCorrente, ExtratoBancario).");

// EX13
int x = 77, y = 66;
Console.WriteLine(x + y);

// EX14
Console.WriteLine("bool = false, char = '\0', int = 0, double = 0, float = 0, decimal = 0, string = null");

/* 

EX15

    (F)     double 1valor = 12.45;
    (F)     string #nome = "Pedro";
    (V)     float _temperatura = 12.45f;
    (F)     double int = 5;
    (F)     decimal renda extra = 91.4m;
    (F)     bool status$conta = false;
    (V)     string titulo3 = "Tópico 1";
    (V)     float salario_mensal = 1999.55f;
    (V)     int percentualValorDesconto = 5;
    (V)     const bool MENSALIDADE_EM_DIA = true;

 */
