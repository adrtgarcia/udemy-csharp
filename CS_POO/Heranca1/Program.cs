Console.WriteLine("Herança");

/*
 
    sintaxe:
        class NomeFilha : NomeMãe
        {
            // declaração dos membros da classe derivada/filha
        }

 */

Funcionario f = new();
f.Nome = "José";
f.Email = "jose@email.com";
f.Salario = 5000.00m;
f.Empresa = "ABC";
f.Identificar();

Aluno a = new();
a.Nome = "Maria";
a.Email = "maria@email.com";
a.Curso = "Computação";
a.Nota = 89;
a.Identificar();

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}