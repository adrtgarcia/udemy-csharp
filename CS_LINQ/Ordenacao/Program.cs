Console.WriteLine("Operadores de Ordenação");

/* obs: é possível aplicar um filtro com where, 
   e depois usar esses operadores para ordenar o filtro obtido */

Console.WriteLine("\nORDER BY");

List<string> nomes = [ "maria", "josé", "ana", "joão" ];
var nomeOrdC = nomes.OrderBy(nome => nome);
foreach (var n in nomeOrdC) Console.Write(n + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nORDER BY DESCENDING");

var nomeOrdD = nomes.OrderByDescending(nome => nome);
foreach (var n in nomeOrdD) Console.Write(n + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nTHEN BY");

List<Aluno> alunos = 
    [
        new Aluno() { Nome = "maria", Idade = 20 },
        new Aluno() { Nome = "manoel", Idade = 22 },
        new Aluno() { Nome = "miriam", Idade = 21 },
        new Aluno() { Nome = "matilda", Idade = 21 }
    ];
var alunoOrdC = alunos.OrderBy(a => a.Nome).ThenBy(a => a.Idade);
foreach (var a in alunoOrdC) Console.Write(a + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nTHEN BY DESCENDING");

var alunoOrdD = alunos.OrderBy(a => a.Nome).ThenByDescending(a => a.Idade);
foreach (var a in alunoOrdD) Console.Write(a + "  ");
Console.WriteLine("\n");

Console.WriteLine("\nREVERSE");

// var alunoRev = alunos.Reverse();     <- não funciona com string, pois retorna void (não está usando o reverse da linq)
// alunos.Reverse();                    <- alternativa de solução 
IEnumerable<string> alunoRev = nomes.AsEnumerable().Reverse();
foreach (var a in alunoRev) Console.Write(a + "  ");
Console.WriteLine("\n");

public class Aluno
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
}
