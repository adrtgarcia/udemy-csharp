// EX04
class A
{
    public int i;
    public void Exibir() { Console.WriteLine(i); }
}
class B : A
{
    public int j;
    public void Exibir() { Console.WriteLine(j); }
}


// EX05
class C
{
    public virtual void Exibir() { Console.WriteLine("C"); }
}
class D : C
{
    public override void Exibir() { Console.WriteLine("D"); }
}


// EX07
public interface IVeiculo
{
    public void Dirigir();
    public bool Abastecer(int qntGasolina);
}
public class Carro : IVeiculo
{
    public int QntGasolina { get; set; }
    public Carro(int qntGasolina)
    {
        QntGasolina = qntGasolina;
    }
    public void Dirigir() 
    { 
        if (QntGasolina > 0)
            Console.WriteLine("dirigindo o carro...");
        else
            Console.WriteLine("sem gasolina...");
    }
    public bool Abastecer(int qntGasolina) 
    {
        QntGasolina += qntGasolina;
        return true;
    }
}


// EX08
public class LivroFotos
{
    protected int numPaginas;
    public LivroFotos() { numPaginas = 16; }
    public LivroFotos(int numPaginas) { this.numPaginas = numPaginas; }
    public int GetNumeroPaginas() { return numPaginas; }
}
public class SuperLivroFotos : LivroFotos
{
    public SuperLivroFotos() { numPaginas = 64; }
}


// EX09, EX10
public class Pessoa
{
    public string? Nome { get; set; }
    public Pessoa(string? nome) { Nome = nome; }
    public override string ToString() { return ($"Nome: {Nome}"); }
}
public class Aluno : Pessoa
{
    public Aluno(string? nome) : base(nome) { Nome = nome; }
    public void Estudar() { Console.WriteLine($"aluno {Nome} estudando..."); }
}
public class Professor : Pessoa
{
    public Professor(string? nome) : base(nome) { Nome = nome; }
    public void Explicar() { Console.WriteLine($"professor {Nome} explicando..."); }
}


// EX11
abstract class Database
{
    public virtual void Conectar() { Console.WriteLine("conectando ao banco de dados..."); }
    public abstract void Configurar();
}
class SQLServer : Database 
{ 
    public override void Conectar() { Console.WriteLine("conectando ao sql server..."); }
    public override void Configurar() { Console.WriteLine("configurando sql server..."); }
}


// EX12
class X
{
    String texto;
    public X(string str) { this.texto = str; }
    public void Exibir() { Console.WriteLine(texto); }
}
class Y : X
{
    public Y(string str) : base(str) { Console.WriteLine(str); }
}


// EX13
interface INota1 { void Classificacao(); }
interface INota2 { void Classificacao(); }
class Exibir : INota1, INota2
{
    //public void Classificacao() { Console.WriteLine("classificação INota1..."); }
    void INota1.Classificacao() { Console.WriteLine("classificação INota2..."); }
    //public void Classificacao() { Console.WriteLine("classificação INota1..."); }
    void INota2.Classificacao() { Console.WriteLine("classificação INota2..."); }
}


// EX14
interface ICartaoCredito { void ValidarCartao(); }
interface ITransacao { void IniciarTransacao(); }
class MastroCreditCard : ICartaoCredito, ITransacao
{
    public void ValidarCartao() { Console.WriteLine("validando cartão..."); }
    public void IniciarTransacao() { Console.WriteLine("iniciando transação..."); }
    public void StatusTransacao() { Console.WriteLine("transação completada..."); }
}


// EX16
public class Forma
{
    public virtual double CalcularArea() { return 0; }
}
public class Quadrado : Forma
{
    public double Lado { get; set; }
    public Quadrado(double lado) { Lado = lado; }
    public override double CalcularArea()
    {
        return (Lado * Lado);
    }
}
public class Triangulo : Forma
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public Triangulo(double b, double a) { Base = b; Altura = a; }
    public override double CalcularArea()
    {
        return ((Base * Altura) / 2);
    }
}
public class Circulo : Forma
{
    public double Raio { get; set; }
    public Circulo(double raio) { Raio = raio; }
    public override double CalcularArea()
    {
        return (Math.PI * Raio * Raio);
    }
}