Console.WriteLine("Operadores de Agregação");

Console.WriteLine("\nAGGREGATE");

string[] cursos = { "c#", "java", "python", "php", "go" };
string cursoStr = cursos.Aggregate((str1, str2) => str1 + ", " + str2);
Console.WriteLine(cursoStr);
Console.WriteLine();

int[] numeros = { 3, 5, 7, 9, 10 };
int produto = numeros.Aggregate((n1, n2) => n1 * n2);
Console.WriteLine(produto);
Console.WriteLine();

List<Aluno> alunos = 
    [
        new Aluno() { Nome = "maria", Idade = 20 },
        new Aluno() { Nome = "joão", Idade = 23 },
        new Aluno() { Nome = "josé", Idade = 21 }
    ];
string nomeAluno = alunos.Aggregate<Aluno, string>(
    "nomes: ", 
    (semente, aluno) => semente += aluno.Nome + ", ");
/* apenas para formatação da string: */
int indice = nomeAluno.LastIndexOf(",");
nomeAluno = nomeAluno.Remove(indice);
Console.WriteLine(nomeAluno);
Console.WriteLine();

nomeAluno = alunos.Aggregate<Aluno, string, string>(
    "nomes: ",
    (semente, aluno) => semente += aluno.Nome + ", ",
    resultado => resultado.Substring(0, resultado.Length-1));
Console.WriteLine(nomeAluno);
Console.WriteLine();

Console.WriteLine("\nAVERAGE");

var mediaIdade = alunos.Average(a => a.Idade);
Console.WriteLine(mediaIdade);
Console.WriteLine();

Console.WriteLine("\nCOUNT");

var numCursos1 = cursos.Count();
Console.WriteLine(numCursos1);
Console.WriteLine();

// var numCursos2 = cursos.Where(c => c.Contains('p')).Count();
var numCursos2 = cursos.Count(c => c.Contains('p'));
Console.WriteLine(numCursos2);
Console.WriteLine();

Console.WriteLine("\nLONG COUNT");

var numCursos3 = cursos.LongCount();
Console.WriteLine(numCursos3);
Console.WriteLine();

// var numCursos2 = cursos.Where(c => c.Contains('p')).Count();
var numCursos4 = cursos.LongCount(c => c.Contains('p'));
Console.WriteLine(numCursos4);
Console.WriteLine();

Console.WriteLine("\nMAX, MAX BY");

int maior = numeros.Max();
Console.WriteLine(maior);
Console.WriteLine();

int maisVelho = alunos.Max(a => a.Idade);
Console.WriteLine(maisVelho);
Console.WriteLine();

Console.WriteLine("\nMIN, MIN BY");

int menor = numeros.Min();
Console.WriteLine(menor);
Console.WriteLine();

int maisNovo = alunos.Min(a => a.Idade);
Console.WriteLine(maisNovo);
Console.WriteLine();

Console.WriteLine("\nSUM");

int soma1 = numeros.Sum();
Console.WriteLine(soma1);
Console.WriteLine();

// int soma2 = numeros.Where(n => n > 5).Sum();
int soma2 = numeros.Sum(n => { if (n > 10) return n; else return 0; });
Console.WriteLine(soma2);
Console.WriteLine();

public class Aluno 
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
}
