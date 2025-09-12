Console.WriteLine("Herança - Sealed");

/*
 
    o modificador SEALED, quando aplicado a uma classe, impede que ela
    seja herdada por outras classes
        - também pode ser usado em método/propriedade que substitui um
          método/propriedade virtual em uma classe base (evitando sua substituição)
 */

Aluno a = new();
a.Nome = "Maria";
a.Nota = 89;
a.ExibeInfo();

/* sealed */ public class Pessoa
{
    public string? Nome { get; set; }
    public void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}
class Aluno : Pessoa
{
    public int Nota { get; set; }
    public void ExibeInfo()
    {
        ExibeNome();
        Console.WriteLine($"Minha nota é {Nota}");
    }
}

class ClasseBase
{
    protected virtual void Metodo1()
    {
        Console.WriteLine("método 1");
    }

    protected virtual void Metodo2()
    {
        Console.WriteLine("método 2");
    }
}

class ClasseFilha1 : ClasseBase
{
    protected override void Metodo1()
    {
        Console.WriteLine("metodo 1 na filha 1");
    }

    /* sealed */ protected override void Metodo2()
    {
        Console.WriteLine("metodo 2 na filha 1");
    }
}

class ClasseFilha2 : ClasseFilha1
{
    protected override void Metodo1()
    {
        Console.WriteLine("metodo 1 na filha 2");
    }

    protected override void Metodo2()
    {
        Console.WriteLine("metodo 2 na filha 2");
    }
}