using UsandoClass;

var usuario = new UsuarioClass
{
    Nome = "João",
    Email = "joao@email.com",
    Idade = 20
};

var usuariocopia = usuario;

Console.WriteLine($"Usuario original : {usuario}");


Console.WriteLine("\nAlterando o email da cópia para : jose@email.com");
//alterando o email 
usuariocopia.Email = "jose@email.com";

Console.WriteLine("\nApós alteração:");
Console.WriteLine($"Conteúdo de usuario original : {usuario}");

Console.ReadKey();