using Exercicios;

Console.WriteLine("Exercícios");

/*

 EX01
    Stack<T> e SortedDictionary<T> estão presentes no System.Collections.Generic 


 EX02
    public class Generic<T>
    {
        public T Campo;
        public void TesteSub() { T i = Campo + 1; }  <- compilador relata erro: o operador '+' não está definido para os tipos T e int
    }
    class MeuPrograma
    {
        static void Main(string[] args)
        {
            Generic<int> gen = new Generic<int>();
            gen.TesteSub();
        }
    }


 EX03
    - Generics é um recurso de linguagem
    - Podemos criar uma classe genérica, porém não podemos criar uma interface genérica em C#
    - Delegates genéricos não são permitidos em C#
    - Generics são úteis em classes de coleção na plataforma .NET

 
 EX04
    Teste teste = new Teste();
    teste.MetodoTeste<string>("Usando Generics -> ");
    teste.MetodoTeste<float>(4.2f);
    Console.ReadKey();
    public class Teste { public void MetodoTeste<T>(T arg) { Console.Write(arg); } }

    O programa vai compilar e na execução imprimirá "Usando Generics -> 4.2f"

 
 EX05
    Generic<String> g = new Generic<String>();
    g.Campo = "Exercício Generics";
    Console.WriteLine(g.Campo);
    Console.ReadKey();
    public class Generic<T> { public T? Campo; }

    Vai imprimir a string "Exercício Generics" no console

 
 EX06
    public class MeuContainer<T> where T : class, IComparable 
    { ... }

    A classe MeuContainer requer que seu argumento de tipo seja um tipo de referência e implementa a interface IComparable.
 

 EX07
    Generics fornecem segurança de tipo sem a sobrecarga de várias implementações

 */

/*
// EX08
Console.WriteLine("\nEX08: Somando números com Generics\n");

Console.WriteLine("digite um número:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("digite um número:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num1} + {num2} = {Calculadora<int>.Somar(num1, num2)}");


// EX09
Console.WriteLine("\nEX09: Lista de Alunos\n");

List<Aluno> alunos = new();
alunos.Add(new Aluno("João", 22, 'M'));
alunos.Add(new Aluno("Maria", 21, 'F'));
alunos.Add(new Aluno("José", 23, 'M'));
alunos.Add(new Aluno("Ana", 20, 'F'));
alunos.Add(new Aluno("Pedro", 24, 'M'));

Console.WriteLine("\nexibindo lista de alunos...\n");
foreach (Aluno a in alunos) a.Exibir();
*/

// EX10
Console.WriteLine("\nEX10: Análise de Parênteses\n");

Stack<char> parenteses = new();
bool balanceado = true;

//Console.WriteLine("digite a expressão matemática:");
//string expressao = Console.ReadLine();
string expressao = "(1+2)*3)-4";

foreach (char c in expressao)
{
    if (c == '(' || c == '[' || c == '{')
        parenteses.Push(c);

    else if (c == ')' || c == ']' || c == '}')
    {
        if (parenteses.Count == 0)
        {
            balanceado = false;
            break;
        }

        var topo = parenteses.Pop();

        if (topo == '(' && c != ')' || topo == '[' && c != ']' || topo == '{' && c != '}')
        {
            balanceado = false;
            break;
        }
    }
}

if (balanceado) 
    Console.WriteLine("os parênteses estão balanceados");
else 
    Console.WriteLine("os parênteses não estão balanceados");


// EX11
Console.WriteLine("\nEX11: Fila de Impressão\n");

Queue<string> impressao = new();
impressao.Enqueue("trabalho de esof");
impressao.Enqueue("prova de ge");
impressao.Enqueue("revisão de tc");
impressao.Enqueue("exercícios de ms");

while (true)
{
    if (impressao.Count != 0)
    {
        var item = impressao.Dequeue();
        Console.WriteLine($"imprimindo item '{item}'...");
        Thread.Sleep(new Random().Next(1000, 6000));
        Console.WriteLine($"item '{item}' impresso com sucesso!\n");
    }
    else
    {
        Console.WriteLine("a fila de impressão está vazia");
        break;
    }
}


// EX12
Console.WriteLine("\nEX12: Revertendo e Imprimindo\n");

int[] arrayInt = { 1, 2, 3, 4, 5};
string[] arrayStr = { "maria", "joão", "josé" };
double[] arrayDou = { 1.2, 2.3, 3.1 };

Console.WriteLine("imprimindo { 1, 2, 3, 4, 5 }");
Exemplo.ReverterEImprimir<int>(arrayInt);
Exemplo.ReverterEImprimir(arrayInt);

Console.WriteLine("\nimprimindo { 'maria', 'joão', 'josé' }");
Exemplo.ReverterEImprimir<string>(arrayStr);
Exemplo.ReverterEImprimir(arrayStr);

Console.WriteLine("\nimprimindo { 1.2, 2.3, 3.1 }");
Exemplo.ReverterEImprimir<double>(arrayDou);
Exemplo.ReverterEImprimir(arrayDou);
