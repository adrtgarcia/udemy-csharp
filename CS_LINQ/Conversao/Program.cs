using System.Collections;
using System.Linq.Expressions;

Console.WriteLine("Operadores de Conversão");

Console.WriteLine("\nTO LIST");

string[] brics = { "brasil", "rússia", "índia", "china", "áfrica do sul" };
var listaBrics = brics.ToList();
foreach (string pais in listaBrics) Console.Write(pais + "  ");
Console.WriteLine();

var alunos = Dados.GetAlunos();
var listaAlunos = alunos.Where(a => a.Nome.Contains('o')).ToList();
foreach(var a in listaAlunos) Console.Write(a.Nome + "  ");
Console.WriteLine();

Console.WriteLine("\nTO ARRAY");

var arrayAlunos = alunos.Where(a => a.Nome.Contains('a')).ToArray();
foreach (var a in arrayAlunos) Console.Write(a.Nome + "  ");
Console.WriteLine();

var arrayNomes = alunos.Select(a => a.Nome).ToArray();
foreach (var n in arrayNomes) Console.Write(n + "  ");
Console.WriteLine();

Console.WriteLine("\nTO DICTIONARY");

var dicAlunos = alunos.ToDictionary<Aluno, int>(a => a.Id);
foreach(var chave in dicAlunos.Keys)
    Console.WriteLine($"chave: {chave} - valor: {(dicAlunos[chave] as Aluno).Nome}");
Console.WriteLine();

Console.WriteLine("\nTO LOOK UP");
/* look up é um dicionário que aceita chaves repetidas */

var infoAlunos = from a in alunos
                 join e in Dados.GetEndereco()
                 on a.EndId equals e.Id
                 join c in Dados.GetCursos()
                 on a.CurId equals c.Id
                 select new
                 {
                     Id = a.Id,
                     Nome = a.Nome,
                     Curso = c.Nome,
                     Endereco = e.Local
                 };

var lookCurso = infoAlunos.ToLookup(a => a.Curso);
foreach (var k in lookCurso)
    foreach (var item in lookCurso[k.Key])
        Console.WriteLine($"{k.Key} - {item.Nome}");
Console.WriteLine();

Console.WriteLine("\nAS ENUMERABLE");
/* converte o tipo específico de uma dada lista em seu tipo equivalente IEnumerable() */

int[] numeros = { 1, 2, 3, 4, 5 };
var numEnum = numeros.AsEnumerable();
foreach (var n in numEnum)
    Console.Write(n + "  ");
Console.WriteLine();

Console.WriteLine("\nAS QUERYABLE");
/* converte IEnumerable em IQueryable */

var numQuery = numeros.AsQueryable(); 
foreach (var n in numQuery)
    Console.Write(n + "  ");
Console.WriteLine();

/*
 
    IEnumerable x IQueryable
        enquanto consulta informações no banco de dados, IEnumerable executa uma consulta 
        Select no lado do servidor, carrega os dados na memória do cliente e então filtra 
        os dados
            * ou seja, mais trabalho -> mais lento
            * os métodos de extensão suportados por IEnumerable usam objetos funcionais
        
        enquanto consulta informações no banco de dados, IQueryable executa uma consulta
        Select no lado do servidor com todos os filtros
            * ou seja, menos trabalho -> mais rápido
            * os métodos de extensão suportados por IQueryable usam objetos Expression,
              ou seja, árvore de expressão

 */

Console.WriteLine("\nCAST");

ArrayList lista = [ 1, 2, 3 ];
IEnumerable<int> novaLista = lista.Cast<int>();
foreach (int i in novaLista) Console.Write(i + "  ");
Console.WriteLine();

Console.WriteLine("\nOF TYPE");
/* filtra dados de tipo específico de uma fonte de dados com base no tipo de dados informado */

List<object> dados = 
    [
        "maria", "joão", 50, "josé", 10, 20, 30, 40, "ana"
    ];

var dadosInt = dados.OfType<int>().ToList();
foreach (var d in dadosInt)
    Console.Write(d + "  ");
Console.WriteLine();

var dadosStr = dados.OfType<string>().Where(str => str.Contains('j')).ToList();
foreach (var d in dadosStr)
    Console.Write(d + "  ");
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
