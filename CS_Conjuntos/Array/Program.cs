Console.WriteLine("Arrays");

/*
    
    SINTAXE:
        tipoDados[] nomeArray;

    FORMAS DE DECLARAÇÃO:
        tipo[] nomeArray = new tipo[tamanho] {valores};
        tipo[] nomeArray = new tipo[] {valores};
        tipo[] nomeArray = {valores};
        tipo[] nomeArray = [valores];      <- forma mais simplificada

    PROPRIEDADES E MÉTODOS DISPONÍVEIS:
        length, rank, copy, clear, sort

 */

int[] numeros = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine(numeros[2]);

string[] alunos = new string[3] { "joão", "maria", "josé" };
Console.WriteLine(alunos[1]);

Array.Reverse(alunos);
foreach (string s in alunos)
{
    Console.Write(s + " ");
}

Array.Sort(alunos);
foreach (string s in alunos)
{
    Console.Write(s + " ");
}

Console.WriteLine($"Posição de 'maria' = {Array.BinarySearch(alunos, "maria")}");
Console.WriteLine($"Posição de 'ana' = {Array.BinarySearch(alunos, "ana")}");

double[] precos = { 1.50, 3.85, 9.70 };
Console.WriteLine(precos[2]);

precos[2] = 4.99;
Console.WriteLine(precos[2]);

char[] letras = ['a', 'b', 'c', 'e', 'f'];
Console.WriteLine(letras[3]);

for (int i = 0; i < letras.Length; i++)
{
    Console.WriteLine($"letras[{i}] = {letras[i]}");
}

foreach (char c in letras)
{
    Console.Write(c + " ");
}


Console.WriteLine("\n\nExercício:");

string[] nomes = new string[5];
double[] notas = new double[5];
double media = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("\nDigite o nome do aluno:");
    nomes[i] = Console.ReadLine();
    Console.WriteLine($"\nDigite a nota de {nomes[i]}:");
    notas[i] = Convert.ToDouble(Console.ReadLine());
    media += notas[i];
}

media /= notas.Count();

Console.WriteLine("\nNomes dos alunos:");
foreach (string nome in nomes)
{
    Console.WriteLine($"{nome}");
}

Console.WriteLine("\nNotas dos alunos:");
foreach (double nota in notas)
{
    Console.WriteLine($"{nota}");
}

Console.WriteLine($"\nMédia aritmética das notas: {media}");


Console.WriteLine("\n\nModificador PARAMS");

/*
 
    PARAMS:
        permite especificar um parâmetro de método que aceita um número variável de argumentos
            - o tipo de parâmetro deve ser um array unidimensional

        NomeMetodo( ... params tipo[] nomeVariavel) { ... }

    CARACTERÍSTICAS:
        - nenhum parâmetro adicional é permitido após a palavra params em uma declaração de método
        - apenas um param é permitido por método
        - deve ser o último argumento da lista de parâmetros
 
 */

Console.WriteLine("Somando { 1, 2, 3, 4, 5, 6 }");
int[] valores = { 1, 2, 3, 4, 5, 6 };
var resultado = Calculadora.Somar(valores);
Console.WriteLine($"Resultado = {resultado}");

Console.WriteLine("Somando 1, 3, 5, 7, 9");
Console.WriteLine($"Resultado = {Calculadora.Somar(1, 3, 5, 7, 9)}");

public class Calculadora
{
    public static int Somar(params int[] numeros)
    {
        int total = 0;
        foreach (int numero in numeros) total += numero;
        return total;
    }

    /*
    public static int Somar(int n1, int n2)
    {
        return (n1 + n2);
    }
    public static int Somar(int n1, int n2, int n3)
    {
        return (n1 + n2 + n3);
    }
    public static int Somar(int n1, int n2, int n3, int n4)
    {
        return (n1 + n2 + n3 + n4);
    }
    */
}