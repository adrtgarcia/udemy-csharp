using Exercicios;

Console.WriteLine("Exercícios");

/*
 EX01 
    (V) Um delegate é um tipo de dado que pode ser usado para encapsular um método e chamá-lo posteriormente
    (V) Para declarar um delegate em C#, é necessário especificar o tipo de retorno do método que ele encapsula, 
        bem como os tipos de parâmetros 
    (V) É possível usar o operador += para adicionar vários métodos a um delegate, que serão chamados em sequência 
        quando o delegate for invocado
    (V) O delegate pode ser passado como parâmetro para outro método, permitindo que o método receptor invoque o 
        método encapsulado no delegate 
    (V) O uso de delegates pode melhorar a modularidade e a flexibilidade do código, permitindo que um método seja 
        substituído por outro sem que isso afete o restante do código 
    (F) Delegates só podem ser usados para encapsular métodos estáticos, não métodos de instância 
    (F) O delegate é um recurso exclusivo da linguagem C#, e não pode ser encontrado em outras linguagens de programação
    (V) Delegates são frequentemente usados em eventos, para permitir que um objeto notifique outros objetos quando 
        ocorre alguma ação
 */


// EX02
Console.WriteLine("\nEX02: Delegate para somar");
OperacaoMatematica op = new OperacaoMatematica(Operacao.Somar);
int resultadoSoma = op(7, 3);
Console.WriteLine($"7 + 3 = {resultadoSoma}");
Console.WriteLine();


// EX03
Console.WriteLine("\nEX03: Delegate de boas-vindas");
MensagensBoasVindas msg = new MensagensBoasVindas(BoasVindas.BoasVindasPt);
msg += BoasVindas.BoasVindasEn;
msg();
Console.WriteLine();


/*
 EX04
    (V) O delegate Action é usado para encapsular um método que recebe um parâmetro e não retorna nenhum valor
    (V) O método Array.ForEach é usado para percorrer todos os elementos de um array e executar um delegate para 
        cada um deles
    (V) O delegate Predicate é usado para encapsular um método que recebe um parâmetro e retorna um valor booleano
    (V) O método Array.TrueForAll retorna true se todos os elementos de um array satisfazem uma condição especificada 
       por um delegate
    (V) O delegate Func é usado para encapsular um método que recebe um ou mais parâmetros e retorna um valor
    (V) O delegate Func pode ter até 16 parâmetros de entrada e um tipo de retorno genérico
    (V) No exemplo acima, o delegate Func é usado para definir um método que soma dois números inteiros
    (V) No exemplo acima, o método somar recebe dois parâmetros e retorna um valor
 */

int[] numeros = { 1, 2, 3, 4, 5 };
// Delegate Action
Action<int> exibirNumero = num => Console.WriteLine(num);
Array.ForEach(numeros, exibirNumero);
// Delegate Predicate
Predicate<int> ehPar = num => num % 2 == 0;
bool todosPares = Array.TrueForAll(numeros, ehPar);
// Delegate Func
Func<int, int, int> somar = (a, b) => a + b;
int resultado = somar(10, 20);
Console.WriteLine(todosPares);
Console.WriteLine(resultado);


// EX05
Console.WriteLine("\nEX05: Delegate de pares");
List<int> inteiros = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
Action<int> exibirPar = num => { if (num % 2 == 0) Console.WriteLine(num); };
inteiros.ForEach(exibirPar);


// EX06
Console.WriteLine("\nEX06: Delegate para somar e subtrair");
int n1 = 7, n2 = 3;
Func<int, int, int> operacao = (n1, n2) => n1 + n2;
Console.WriteLine($"\n{n1} + {n2} = {Operacoes.Operar(n1, n2, operacao)}");
operacao = (n1, n2) => n1 - n2;
Console.WriteLine($"\n{n1} - {n2} = {Operacoes.Operar(n1, n2, operacao)}");


// EX07
Console.WriteLine("\nEX07: Delegate de planetas");
List<Planeta> planetas = Planeta.GetPlanetas();

Predicate<Planeta> filtro = p => p.Diametro > 10000;
List<Planeta> planetaGrande = Planeta.Filtrar(planetas, filtro);

Console.WriteLine("\nLista de planetas com diâmetro > 10000\n");
foreach (Planeta p in planetaGrande)
    Console.WriteLine(p.Nome);


/*
 EX08
     Função lambda é uma função anônima que pode ser passada como argumento para outros métodos e que pode ser definida 
        em apenas uma linha de código
 */


// EX09
Console.WriteLine("\nEX09: Extensão de lista");
List<int> listaInteiros = new();
listaInteiros.Add(1);
listaInteiros.Add(2);
listaInteiros.Add(3);
listaInteiros.Add(4);
listaInteiros.Add(5);
listaInteiros.Add(6);
listaInteiros.Add(7);
listaInteiros.Add(8);
listaInteiros.Add(9);

Console.WriteLine("\nLista:");
foreach (int i in listaInteiros) Console.Write(i + "   ");
int somaLista = ListExtensions.SomaImpar(listaInteiros);
Console.WriteLine($"\nSoma dos inteiros: {somaLista}");


// EX10
Console.WriteLine("\nEX10: Consultas LINQ");

Console.WriteLine("\nWHERE");
string[] nomes = { "maria", "ana", "joão", "josé" };
foreach (string n in nomes) Console.Write(n + "   ");
Console.WriteLine();
var nomesComA = nomes.Where(n => n.Contains('a'));
foreach (var item in nomesComA) Console.Write(item + "   ");
Console.WriteLine();

Console.WriteLine("\nORDER BY");
int[] numerosInteiros = { 1, 5, 2, 8, 4, 6, 3, 7, 9 };
foreach (int i in numerosInteiros) Console.Write(i + "   ");
Console.WriteLine();
var numerosCrescente = numerosInteiros.OrderBy(n => n);
foreach (var item in numerosCrescente) Console.Write(item + "   ");
Console.WriteLine();

Console.WriteLine("\nGROUP BY");
foreach (string n in nomes) Console.Write(n + "   ");
Console.WriteLine();
var nomesTamanho = nomes.GroupBy(n => n.Length);
foreach (var tamanho in nomesTamanho)
{
    Console.WriteLine($"\nPalavras com tamanho {tamanho.Key}");
    foreach (var palavra in tamanho)
    {
        Console.Write(palavra + "   ");
    }
}
Console.WriteLine();

Console.WriteLine("\nFIRSTORDEFAULT");
foreach (int i in numerosInteiros) Console.Write(i + "   ");
Console.WriteLine();
var numeroPar = numerosInteiros.FirstOrDefault(n => n % 2 == 0);
Console.WriteLine(numeroPar);
