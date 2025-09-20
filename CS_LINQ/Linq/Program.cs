Console.WriteLine("Apresentando os fundamentos");

IList<string> frutas =
[
    "banana", "maçã", "pera", "laranja", "uva"
];

// query syntax
var resultado1 = from f in frutas
                 where f.Contains('r')
                 select f;

Console.WriteLine("\nResultado com Query Syntax");
Console.WriteLine(String.Join(" ", resultado1));

// method syntax
var resultado2 = frutas.Where(f => f.Contains('r'));

Console.WriteLine("\nResultado com Method Syntax");
Console.WriteLine(String.Join(" ", resultado2));

Console.WriteLine("\nConsultas LINQ\n");

List<string> nomes = 
[
    "maria", "joão", "josé", "ana"
];

string? rNome = nomes.Find(nome => nome.Equals("joão"));
Console.WriteLine($"\nNome encontrado: {rNome}");

List<int> numeros = [ 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 ];

var rNum1 = numeros.Where(n => n < 10);
Console.WriteLine($"\nNúmeros encontrados: {String.Join(" ", rNum1)}");

var rNum2 = numeros.Where(n => (n > 1) && (n != 4) && (n < 20));
Console.WriteLine($"\nNúmeros encontrados: {String.Join(" ", rNum2)}");

List<int> listaNegra = [ 16, 128, 512 ];

var rNum3 = numeros.Where(n => !listaNegra.Contains(n));
Console.WriteLine($"\nNúmeros encontrados: {String.Join(" ", rNum3)}");

List<Aluno> alunos =
[
    new Aluno() { Nome = "maria", Idade = 20},    
    new Aluno() { Nome = "joão", Idade = 22},    
    new Aluno() { Nome = "josé", Idade = 20},    
    new Aluno() { Nome = "ana", Idade = 21},    
];

var rAluno1 = alunos.Where(a => (a.Nome.StartsWith('j')) && (a.Idade < 22));
Console.WriteLine($"\nAlunos encontrados: {String.Join(" ", rAluno1)}");

public class Aluno
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
}
