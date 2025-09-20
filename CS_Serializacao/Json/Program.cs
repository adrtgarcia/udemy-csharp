using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("Serialização JSON");

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
 
    serialização json:
        - serializa somente propriedades públicas
        - não preserva a fidelidade do tipo 
 
 */

Aluno a = new(101, "Maria", "maria@email.com", 17);
var caminho = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\maria.json";

using (FileStream fs = new(caminho, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(fs, a);
}

Console.WriteLine("Serialização concluída");

string json = File.ReadAllText(caminho);
var aluno = JsonSerializer.Deserialize<Aluno>(json);

Console.WriteLine($"Aluno: {aluno.Nome}");
Console.WriteLine($"ID: {aluno.Id}");
Console.WriteLine($"Idade: {aluno.Idade}");
Console.WriteLine($"Email: {aluno.Email}");

Console.WriteLine("Desserialização concluída");

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
