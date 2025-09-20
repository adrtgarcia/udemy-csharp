using System.Text.Json;
using System.Xml.Serialization;

Console.WriteLine("Exercício - Serialização");

List<Aluno> alunos = 
[
    new Aluno(101, "maria", "maria@email.com", 17),
    new Aluno(202, "joão", "joao@email.com", 17),
    new Aluno(303, "josé", "jose@email.com", 16)
];

Console.WriteLine("\nJSON");
var pathjson = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\serializacao\alunos.json";

string listaj = JsonSerializer.Serialize(alunos);
Console.WriteLine(listaj);

using (FileStream fs = new(pathjson, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(fs, alunos);
}

Console.WriteLine("\nSerialização JSON concluída");

Console.WriteLine("\nXML");
var pathxml = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\serializacao\alunos.xml";

var listax = new XmlSerializer(typeof(List<Aluno>));
Console.WriteLine(listaj);

using (StreamWriter sw = new(pathxml))
{
    listax.Serialize(sw, alunos);
}

Console.WriteLine("\nSerialização XML concluída");

public class Aluno
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }

    // [JsonIgnore] impede a serialização de alguma informação
    public int Idade { get; set; }

    public Aluno() { }
    public Aluno(int id, string nome, string email, int idade)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Idade = idade;
    }
}
