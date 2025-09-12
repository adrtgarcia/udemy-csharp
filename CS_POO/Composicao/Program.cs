Console.WriteLine("Composição e Agregação");

/*
 
    herança: relacionamento "é um"
    composição: relacionamento "tem um" (associação forte)
        - representa sistemas de objetos, onde todos os componentes devem estar presentes
        - a parte é dependente do todo
    agregação: relacionamento "tem um" (associação fraca)
        - representa relações entre objetos que podem estar vazias ou conter um número variável de participantes
        - a parte é independente do todo
    
 */

Casa c = new();
c.telhado.ExibirTelhado();
c.alicerce.ExibirAlicerce();
Console.WriteLine("\n\n\n");

Departamento d = new("Computação");
d.IncluirProfessor(new Professor("Maria", "Banco de Dados"));
d.IncluirProfessor(new Professor("Elaine", "Orientação a Objetos"));
d.IncluirProfessor(new Professor("Claudio", "Arquitetura e Organização"));
d.IncluirProfessor(new Professor("Julia", "Programação Funcional"));
d.IncluirProfessor(new Professor("Fabiano", "Engenharia de Software"));
d.ListarProfessores();

//composição:
public class Casa 
{
    public Telhado telhado;
    public Alicerce alicerce;
    public Casa()
    {
        telhado = new Telhado();
        alicerce = new Alicerce();
    }
}
public class Telhado { public void ExibirTelhado() { Console.WriteLine("telhado da casa"); } }
public class Alicerce { public void ExibirAlicerce() { Console.WriteLine("alicerce da casa"); } }

// agregação:
public class Departamento
{
    public string? Nome { get; set; }
    public List<Professor>? Professores { get; set; }
    
    public Departamento(string? nome) 
    {
        Nome = nome;
        Professores = new List<Professor>();
    }

    public void IncluirProfessor(Professor professor)
    {
        Professores?.Add(professor);
    }

    public void ListarProfessores()
    {
        Console.WriteLine($"Departamento de {Nome}");
        foreach (Professor p in Professores)
        {
            Console.WriteLine($"{p.Nome}\t\t\t{p.Disciplina}");
        }
    }
}

public class Professor
{
    public string? Nome { get; set; }
    public string? Disciplina { get; set; }

    public Professor(string? nome, string? disciplina)
    {
        Nome = nome;
        Disciplina = disciplina;
    }
}