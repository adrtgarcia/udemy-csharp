using System.Collections.ObjectModel;

Console.WriteLine("ReadOnlyCollection<T>");

Console.WriteLine("\ncriando a coleção...\n");
var exo1 = new ReadOnlyCollection<ExoPlaneta>(ExoPlaneta.GetExoPlanetas());
foreach (ExoPlaneta ep in exo1) { Console.WriteLine($"{ep.Nome}  "); }
Console.WriteLine("\n");

Console.WriteLine("\ntentando modificar a coleção...\n");
exo1[0].Nome = "Kleper 442-b";
foreach (ExoPlaneta ep in exo1) { Console.WriteLine($"{ep.Nome}  "); }
Console.WriteLine("\n");

/*
 
    cenários onde é possível alterar uma coleção read-only:
        - alterando a coleção original
        - usando tipos complexos na coleção read-only

    como proteger melhor os dados: encapsulamento
 
 */

Console.WriteLine("\ncriando a coleção...\n");
GerenciaLista gl = new();
var exo2 = gl.ExoPlanetas;
foreach (ExoPlaneta ep in exo2) { Console.WriteLine($"{ep.Nome}  "); }
Console.WriteLine("\n");

Console.WriteLine("\ntentando modificar a coleção...\n");
exo2[0].Nome = "Kleper 442-b";      /*  <- continua alterando  */
foreach (ExoPlaneta ep in exo2) { Console.WriteLine($"{ep.Nome}  "); }
Console.WriteLine("\n");

Console.WriteLine("\ntentando adicionar com o método criado...\n");
gl.AdicionarPlaneta(new ExoPlaneta() { Nome = "Kleper 442-b" });
foreach (ExoPlaneta ep in exo2) { Console.WriteLine($"{ep.Nome}  "); }
Console.WriteLine("\n");

public class ExoPlaneta
{
    public string? Nome { get; set; }
    
    public static List<ExoPlaneta> GetExoPlanetas()
    {
        return new List<ExoPlaneta>()
        {
            new ExoPlaneta() { Nome = "Próxima Centauri b" },
            new ExoPlaneta() { Nome = "Kleper 186-f" },
            new ExoPlaneta() { Nome = "Gliesi 1061-c" }
        };
    }
}

public class GerenciaLista
{
    private List<ExoPlaneta>? exoPlanetas = ExoPlaneta.GetExoPlanetas();

    public ReadOnlyCollection<ExoPlaneta> ExoPlanetas
    {
        get { return exoPlanetas.AsReadOnly(); }
    }

    public void AdicionarPlaneta(ExoPlaneta planeta)
    {
        exoPlanetas?.Add(planeta);
    }
}
