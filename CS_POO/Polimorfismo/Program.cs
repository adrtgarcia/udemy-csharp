Console.WriteLine("Polimorfismo");

/*
 
    o polimorfismo permite a invocação de métodos da classe derivada através da classe base em tempo
    de execução, e também permite que classes forneçam diferentes implementações de métodos que são chamados
    com o mesmo nome
 
    overloading ou sobrecarga (em tempo de compilação)
        - utiliza a sobrecarga de métodos e operadores
        - também chamado de ligação precoce (early binding)
        - a utilização da sobrecarga de métodos realiza a tarefa com distintos parâmetros de entrada

    overriding ou sobrescrita (em tempo de execução)
        - feito por meio de herança e métodos virtuais 
        - também chamado de ligação tardia (late binding)
        - ao sobrescrever os métodos virtuais, o comportamento dos métodos é alterado para a classe derivada

    aplicação no c#:
        1) herança: membros são sobrescritos
        2) interface: implementação da interface com comportamentos diferentes
        3) classe abstrata: inclusão dos detalhes de implementação nos métodos abstratos

 */

var figuras = new List<Figura>
{
    new Circulo(),
    new Quadrado(),
    new Triangulo()
};

foreach (Figura f in figuras) f.Desenhar();

Calculadora c = new();
Console.WriteLine(c.Somar(30, 40));
Console.WriteLine(c.Somar(30, 40, 50));

public class Figura
{
    public virtual void Desenhar()
    {
        Console.WriteLine("desenhando na classe forma");
    }
}

public class Circulo : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("desenhando na classe círculo");
    }
}

public class Quadrado : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("desenhando na classe quadrado");
    }
}

public class Triangulo : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("desenhando na classe triângulo");
    }
}

public class Calculadora
{
    public int Somar(int num1, int num2) { return num1 + num2; }
    public int Somar(int num1, int num2, int num3) { return num1 + num2 + num3; }
}