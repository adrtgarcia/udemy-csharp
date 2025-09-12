Console.WriteLine("Classe Abstrata");

/*
 
    ABSTRACT indica que o recurso está sendo modificado tem uma
    implementação ausente ou incompleta
        - classe: indica que é uma classe base, não pode ser instanciada
        - membro: indica que deve ser implementado em classe não abstrata
 
 */

Quadrado q = new();
Console.WriteLine(q.Descricao());

q.Cor = "rosa";
q.Lado = 5;
q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"Cor: {q.Cor}");
Console.WriteLine($"Área: {q.Area}");
Console.WriteLine($"Perímetro: {q.Perimetro}");

public abstract class Forma
{
    public string Cor { get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();

    public string Descricao()
    {
        return "classe abstrata FORMA";
    }
}

public class Quadrado : Forma
{
    public double Lado { get; set; }
    public override void CalcularArea()
    {
        this.Area = Lado * Lado;
    }
    public override void CalcularPerimetro()
    {
        this.Perimetro = 4 * Lado;
    }
}