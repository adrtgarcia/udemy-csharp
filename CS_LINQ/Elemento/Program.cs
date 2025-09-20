Console.WriteLine("Operadores de Elemento");

Console.WriteLine("\nJOIN com múltiplos conjuntos\n");

List<Aluno> alunos = Dados.GetAlunos();
List<Endereco> enderecos = Dados.GetEndereco();
List<Curso> cursos = Dados.GetCursos();

int[] numeros = { 10, 20, 30, 40, 50 };
double[] precos = { };
double[] notas = { };

var infoAlunos = from a in alunos
                 join e in enderecos
                 on a.EndId equals e.Id
                 join c in cursos
                 on a.CurId equals c.Id
                 select new
                 { 
                     Id = a.Id,
                     Nome = a.Nome,
                     Curso = c.Nome,
                     Endereco = e.Local
                 };

foreach (var aluno in infoAlunos) 
    Console.WriteLine($"{aluno.Id}: {aluno.Nome} - Curso: {aluno.Curso}, Endereço: {aluno.Endereco}");
Console.WriteLine();

Console.WriteLine("\nELEMENT AT");
/* lança exceção se não acha nada */

int num3 = numeros.ElementAt(3);
Console.WriteLine(num3);
Console.WriteLine();

Aluno aluno2 = alunos.ElementAt(2);
Console.WriteLine(aluno2.ToString());
Console.WriteLine();

Console.WriteLine("\nELEMENT AT OR DEFAULT");
/* atribui valor padrão ao invés de lançar exceção */

int num10 = numeros.ElementAtOrDefault(10);
Console.WriteLine(num10);
Console.WriteLine();

Console.WriteLine("\nFIRST");
/* lança exceção se não acha nada */

Aluno primeiroAluno = alunos.First();
Console.WriteLine(primeiroAluno.ToString());
Console.WriteLine();

int primeiroPar = numeros.First(n => n % 2 == 0);
Console.WriteLine(primeiroPar);
Console.WriteLine();

Console.WriteLine("\nFIRST OR DEFAULT");
/* atribui valor padrão ao invés de lançar exceção */

int primeiroMaior50 = numeros.FirstOrDefault(n => n > 50);
Console.WriteLine(primeiroMaior50);
Console.WriteLine();

Console.WriteLine("\nLAST");
/* lança exceção se não acha nada */

Aluno ultimoAluno = alunos.Last();
Console.WriteLine(ultimoAluno.ToString());
Console.WriteLine();

int ultimoPar = numeros.Last(n => n % 2 == 0);
Console.WriteLine(ultimoPar);
Console.WriteLine();

Console.WriteLine("\nLAST OR DEFAULT");
/* atribui valor padrão ao invés de lançar exceção */

int ultimoMaior50 = numeros.LastOrDefault(n => n > 50);
Console.WriteLine(ultimoMaior50);
Console.WriteLine();

Console.WriteLine("\nSINGLE");
/* lança exceção se não acha nada */
/* lança exceção se mais de um elemento é encontrado */

int parMaior30 = numeros.Single(n => (n > 30) && (n % 2 == 0));
Console.WriteLine(parMaior30);
Console.WriteLine();

Console.WriteLine("\nSINGLE OR DEFAULT");
/* atribui valor padrão ao invés de lançar exceção quando não acha nada */
/* lança exceção se mais de um elemento é encontrado */

int parMaior50 = numeros.Single(n => (n > 50) && (n % 2 == 0));
Console.WriteLine(parMaior50);
Console.WriteLine();

Console.WriteLine("\nDEFAULT EMPTY");
/* retorna os elementos da coleção ou o valor padrão do parâmetro de tipo em uma 
   coleção de singletons se a coleção estiver vazia */

var listaNumeros = numeros.DefaultIfEmpty();
foreach (var n in listaNumeros) Console.Write(n + "  ");
Console.WriteLine();

var listaPrecos = precos.DefaultIfEmpty();
foreach (var p in listaPrecos) Console.Write(p + "  ");
Console.WriteLine();

var listaNotas = notas.DefaultIfEmpty(5.5);
foreach (var p in listaPrecos) Console.Write(p + "  ");
Console.WriteLine();

public class Aluno
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public int EndId { get; set; }
    public int CurId { get; set; }
}
public class Endereco
{
    public int Id { get; set; }
    public string? Local { get; set; }
}
public class Curso
{
    public int Id { get; set; }
    public string? Nome { get; set; }
}
public static class Dados
{
    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos =
            [
                new Aluno() { Id = 1, Nome = "maria", EndId = 1, CurId = 1 },
                new Aluno() { Id = 2, Nome = "ana", EndId = 1, CurId = 2 },
                new Aluno() { Id = 3, Nome = "joão", EndId = 2, CurId = 3 },
                new Aluno() { Id = 4, Nome = "josé", EndId = 3, CurId = 1 },
                new Aluno() { Id = 5, Nome = "paula", EndId = 4, CurId = 2 }
            ];
        return alunos;
    }
    public static List<Endereco> GetEndereco()
    {
        List<Endereco> enderecos =
            [
                new Endereco() { Id = 1, Local = "rua ABC, 100"},
                new Endereco() { Id = 2, Local = "rua DEF, 200"},
                new Endereco() { Id = 3, Local = "rua GHI, 300"},
                new Endereco() { Id = 4, Local = "rua JKL, 400"},
            ];
        return enderecos;
    }
    public static List<Curso> GetCursos()
    {
        List<Curso> cursos =
            [
                new Curso() { Id = 1, Nome = "matemática" },
                new Curso() { Id = 2, Nome = "física" },
                new Curso() { Id = 3, Nome = "química" }
            ];
        return cursos;
    }
}
