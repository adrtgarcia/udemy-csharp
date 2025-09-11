Console.WriteLine("Classes e Métodos");

Pessoa p1 = new Pessoa();       // var p1 = new Pessoa(); Pessoa p1 = new();
p1.nome = "maria";
p1.idade = 25;
p1.sexo = "feminino";

Pessoa p2 = new Pessoa();
p2.nome = "joão";
p2.idade = 26;
p2.sexo = "masculino";

Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");
Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}