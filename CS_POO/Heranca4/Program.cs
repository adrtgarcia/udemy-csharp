Console.WriteLine("Herança - Object");

/*
 
    toda classe é derivada de Object, mas ela não deriva de nenhuma
        - dá suporte a tofas as classes na hierarquia .NET
        - oferece serviços de baixo nível para classes derivadas

    métodos:
        - Equals() faz comparações entre objetos
        - GetHashCode() gera um número hash para o objeto
        - ToString() retorna a representação em string
        - GetType() retorna o tipo
 
 */

Pessoa p = new("maria");
Console.WriteLine(p.Equals("ana"));
Console.WriteLine(p.Equals("maria"));
Console.WriteLine(p.Equals(new Pessoa("maria")));
Console.WriteLine(p.ToString());
Console.WriteLine(p.GetType());
Console.WriteLine(p.GetHashCode());

public class Pessoa 
{
    public string? Nome { get; set; }
    public Pessoa(string nome)
    {
        Nome = nome;
    }
}