Console.WriteLine("GetHashCode e Equals");

/*
    
    GetHashCode e Equals são métodos da classe Object usados para comparar se
    dois objetos são iguais
        - GetHashCode: retorna um valor inteiro (código hash) com base nas informações
                       do objeto (estado)
        - Equals: compara o objeto com outro objeto e retorna um booleano indicando se
                  eles são iguais
 
    Importante: Nos tipos definidos pelo usuário, é necessário sobrescrever ambos
                para garantir que a igualdade entre dois objetos do tipo seja avaliada
                da forma correta

 */

string stra = "josé";
string strb = "josé";

int x = 100;
int y = 500;

var p1 = new Pessoa(12345, "maria");
var p2 = new Pessoa(12345, "maria");

Console.WriteLine("\nutilizando equals... ");
Console.WriteLine($"{stra} é igual a {strb}? {stra.Equals(strb)}");
Console.WriteLine($"{x} é igual a {y}? {x.Equals(y)}");
Console.WriteLine($"{p1} é igual a {p2}? {p1.Equals(p2)}");

Console.WriteLine("\nutilizando gethashcode...");
Console.WriteLine($"{stra} = {stra.GetHashCode()} e {strb} = {strb.GetHashCode()} -> {stra.GetHashCode() == strb.GetHashCode()}");
Console.WriteLine($"{x} = {x.GetHashCode()} e {y} = {y.GetHashCode()} -> {x.GetHashCode() == y.GetHashCode()}");
Console.WriteLine($"{p1} = {p1.GetHashCode()} e {p2} = {p2.GetHashCode()} -> {p1.GetHashCode() == p2.GetHashCode()}");

/*
 
    objetos diferentes sempre vão gerar um código hash diferente, mas códigos hash iguais não significam
    que os objetos são iguais, pois podem existir diferentes objetos com os mesmos códigos hash (é raro,
    mas pode acontecer)
 
 */

Console.WriteLine("\ncomparando pessoas...");
Console.WriteLine($"{p1} é igual a {p2}? {p1.Equals(p2)}");
Console.WriteLine($"{p1} = {p1.GetHashCode()} e {p2} = {p2.GetHashCode()} -> {p1.GetHashCode() == p2.GetHashCode()}");

var p3 = new Pessoa(56789, "maria");
Console.WriteLine($"{p3} é igual a {p1}? {p3.Equals(p1)}");
Console.WriteLine($"{p3} é igual a {p2}? {p3.Equals(p2)}");
Console.WriteLine($"{p3} = {p3.GetHashCode()} e {p1} = {p1.GetHashCode()} -> {p3.GetHashCode() == p1.GetHashCode()}");
Console.WriteLine($"{p3} = {p3.GetHashCode()} e {p2} = {p2.GetHashCode()} -> {p3.GetHashCode() == p2.GetHashCode()}");

public class Pessoa
{
    public int Cpf { get; set; }
    public string? Nome { get; set; }
    public Pessoa(int cpf, string? nome)
    {
        Cpf = cpf;
        Nome = nome;
    }
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj is not Pessoa) return false;
        var other = (Pessoa)obj;
        return Cpf.Equals(other.Cpf);
    }
    public override int GetHashCode()
    {
        return Cpf.GetHashCode();
    }
    public override string ToString()
    {
        return ($"{Nome}");
    }
}