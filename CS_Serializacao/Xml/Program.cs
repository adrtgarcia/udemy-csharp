using System.Xml.Serialization;

Console.WriteLine("Serialização XML");

/*
 
    Serialização é o processo de conversão do estado de um objeto em um formato que possa ser
    armazenado e/ou transportado
        - em outras palavras: 
          é o processo de conversão de um objeto em um fluxo de bytes (stream) de forma que possa
          ser armazenado na memória, em arquivo ou em um banco de dados
    
    Desserialização é o complemento da serialização, que converte um fluxo de bytes (stream)
    em um objeto   
  
 */

/*
 
    serialização xml ou soap:
        - serializa somente propriedades públicas
        - não preserva a fidelidade do tipo
 
 */

Aluno a = new(101, "Maria", "maria@email.com", 17);
var caminho = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\maria.xml";

XmlSerializer xs = new(typeof(Aluno));
using (StreamWriter sw = new(caminho))
{
    xs.Serialize(sw, a);
}

Console.WriteLine("Serialização concluída");

using (StreamReader sr = new(caminho))
{
    var aluno = (Aluno)xs.Deserialize(sr);
    Console.WriteLine($"Aluno: {aluno.Nome}");
    Console.WriteLine($"ID: {aluno.Id}");
    Console.WriteLine($"Idade: {aluno.Idade}");
    Console.WriteLine($"Email: {aluno.Email}");
}

Console.WriteLine("Desserialização concluída");

public class Aluno
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
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
