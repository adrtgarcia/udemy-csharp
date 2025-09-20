using System.Threading.Tasks.Sources;

Console.WriteLine("Operadores de Quantificação");

Console.WriteLine("\nALL");

int[] numeros = { 10, 22, 32, 44, 56, 64, 78 };
var ehPar = numeros.All(n => n % 2 == 0);
Console.WriteLine($"{(ehPar? "todos são pares" : "nem todos são pares")}");
Console.WriteLine();

List<Funcionario> funcionarios =
    [
        new Funcionario() { Nome = "maria", Idade = 35, Salario = 3850.00, Cachorros = [ 
                    new Cachorro() { Nome = "bilu", Idade = 6, Vacinado = true },
                    new Cachorro() { Nome = "canelinha", Idade = 3, Vacinado = false } ] },
        new Funcionario() { Nome = "joão", Idade = 32, Salario = 2490.00, Cachorros = [
                    new Cachorro() { Nome = "pipoca", Idade = 6, Vacinado = true },
                    new Cachorro() { Nome = "mel", Idade = 7, Vacinado = false } ] },
        new Funcionario() { Nome = "josé", Idade = 25, Salario = 3500.00, Cachorros = [
                    new Cachorro() { Nome = "belinha", Idade = 8, Vacinado = true } ] }
    ];
var maior25 = funcionarios.All(f => f.Idade > 25);
Console.WriteLine($"{(maior25? "todos têm mais de 25 anos" : "nem todos têm mais de 25 anos")}");
Console.WriteLine();

var funcNome = from f in funcionarios
               where f.Cachorros.All(c => c.Idade > 5)
               select f.Nome;
foreach (var n in funcNome) Console.Write($"{n}  ");
Console.WriteLine();

Console.WriteLine("\nANY");

string[] cursos = { "c#", "java", "python", "php", "asp.net", "node" };
var temCurso = cursos.Any();
var temCursoMaior2 = cursos.Any(c => c.Length > 2);
Console.WriteLine(temCurso + " - " + temCursoMaior2);
Console.WriteLine();

List<Cachorro> cachorros = 
    [
        new Cachorro() { Nome = "bilu", Idade = 6, Vacinado = true },
        new Cachorro() { Nome = "canelinha", Idade = 3, Vacinado = false },
        new Cachorro() { Nome = "pipoca", Idade = 8, Vacinado = true }
    ];
var naoVacinado = cachorros.Any(p => (p.Idade > 2) && (p.Vacinado == false));
Console.WriteLine($"{(naoVacinado? "existem" : "não existem")} cães com mais de 2 anos não vacinados");
Console.WriteLine();

Console.WriteLine("\nCONTAINS");

var existeMaria = funcionarios.Contains(new Funcionario()
{
    Nome = "maria",
    Idade = 35,
    Salario = 3850.00,
    Cachorros = [
                    new Cachorro() { Nome = "bilu", Idade = 6, Vacinado = true },
                    new Cachorro() { Nome = "canelinha", Idade = 3, Vacinado = false } 
                ]
});
Console.WriteLine($"{(existeMaria ? "sim" : "não")} existe uma funcionária maria"); /* compara a referência, não os valores */
Console.WriteLine();                                                                /* solução: implementar uma classe IEqualityComparer */

public class Funcionario
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public double Salario { get; set; }
    public List<Cachorro>? Cachorros { get; set; }
}
public class Cachorro
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public bool Vacinado { get; set; }
}
