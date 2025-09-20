Console.WriteLine("Paginação com Skip e Take");

/* 
 
    PAGINAÇÃO é uma técnica usada para dividir um grande conjunto de resultados em 
    vários resultados menores, chamados páginas, que estão conectadas entre si
        - em cada página, são exibidos um determinado número de resultados, onde
          podemos navegar entre as páginas para percorrer o conjunto de resultados

    > NP: número da página, da qual vamos obter os dados
    > NRP: número de registros por página, definida pelo tamanho da página

    fórmula padrão para paginação:
        Resultado = DataSource.Skip((NP - 1) * NRP).Take(NRP)

 */

int nrp = 4;
int np;

do
{
    Console.WriteLine("\ninforme o número de páginas (1-4):");
    if (int.TryParse(Console.ReadLine(), out np))
    {
        if (np > 0 && np < 5)
        {
            var alunos = Dados.GetAlunos()
                .Skip((np - 1)*nrp)
                .Take(nrp)
                .ToList();

            foreach (var a in alunos)
                Console.WriteLine($"ID: {a.Id}\t\tNome: {a.Nome}\t\tCurso: {a.Curso}");
        }
        else
            Console.WriteLine("\ninforme um número válido");
    }
    else
        Console.WriteLine("\ninforme um número válido");
} 
while (true);

public class Aluno
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Curso { get; set; }
}
public static class Dados
{
    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos =
            [
                new Aluno() { Id = 1, Nome = "maria", Curso = "java" },
                new Aluno() { Id = 2, Nome = "joão", Curso = "node" },
                new Aluno() { Id = 3, Nome = "josé", Curso = "c#" },
                new Aluno() { Id = 4, Nome = "ana", Curso = "sql" },
                new Aluno() { Id = 5, Nome = "pedro", Curso = "java" },
                new Aluno() { Id = 6, Nome = "paulo", Curso = "sql" },
                new Aluno() { Id = 7, Nome = "bianca", Curso = "c#" },
                new Aluno() { Id = 8, Nome = "alice", Curso = "python" },
                new Aluno() { Id = 9, Nome = "sara", Curso = "node" },
                new Aluno() { Id = 10, Nome = "rafael", Curso = "python" },
                new Aluno() { Id = 11, Nome = "gabriel", Curso = "java" },
                new Aluno() { Id = 12, Nome = "helena", Curso = "c#" },
                new Aluno() { Id = 13, Nome = "renato", Curso = "php" },
                new Aluno() { Id = 14, Nome = "luisa", Curso = "python" },
                new Aluno() { Id = 15, Nome = "mateus", Curso = "php" },
                new Aluno() { Id = 16, Nome = "carlos", Curso = "c#" }
            ];
        return alunos;
    }
}
