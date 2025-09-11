using System.Threading.Channels;

Console.WriteLine("Métodos");

MinhaClasse mc = new MinhaClasse();
mc.DizerBemVindo();
mc.DizerTchau();
mc.DizerOla("maria");

Aluno a1 = new Aluno();
a1.nome = "joão";
a1.idade = 20;
a1.sexo = 'M';
a1.aprovado = true;

Curso c = new Curso();
c.ImprimirResultado(a1.nome, a1.idade, a1.sexo, a1.aprovado);
c.ImprimirResultado(a1);

Calculadora calc = new Calculadora();
Console.WriteLine(calc.Somar(10, 20));
Console.WriteLine(calc.Subtrair(50, 35));
Console.WriteLine(calc.Multiplicar(5, 7));
Console.WriteLine(calc.Dividir(9, 3));

public class MinhaClasse
{
    public void DizerBemVindo() // <- por default, métodos são private
    {
        Console.WriteLine("bem-vindo");
        Console.WriteLine(DateTime.Now);
    }

    public void DizerTchau() =>
        Console.WriteLine("até logo");

    public void DizerOla(string nome)
    {
        Console.WriteLine($"olá, {nome}");
    }
}

public class Aluno
{
    public string? nome;
    public int idade;
    public char sexo;
    public bool aprovado;
}

public class Curso
{
    public void ImprimirResultado(string nome, int idade, char sexo, bool aprovado)
    {
        Console.WriteLine("\nInformações do aluno:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Sexo: {sexo}");

        if (aprovado)
            Console.WriteLine("Situação: APROVADO");
        else
            Console.WriteLine("Situação: REPROVADO");
    }
    public void ImprimirResultado(Aluno a)
    {
        Console.WriteLine("\nInformações do aluno:");
        Console.WriteLine($"Nome: {a.nome}");
        Console.WriteLine($"Idade: {a.idade}");
        Console.WriteLine($"Sexo: {a.sexo}");
        
        if (a.aprovado)
            Console.WriteLine("Situação: APROVADO");
        else
            Console.WriteLine("Situação: REPROVADO");
    }
}

public class Calculadora
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Dividir(int num1, int num2)
    {
        if (num2 != 0)
            return num1 / num2;
        else
            return -99999;
    }
}