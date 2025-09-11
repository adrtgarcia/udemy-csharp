Console.WriteLine("Exercício 06");

ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null);
static void ProcessaObjetos(params object[] vetor)
{
    if (vetor != null)
        foreach (var obj in vetor)
            Console.WriteLine($"Valor: {obj} \t Tipo: {obj?.GetType()}");
    else
        Console.WriteLine("\nVetor vazio");
}

public class Teste { }
