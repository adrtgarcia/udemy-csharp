using UsandoRecord;

var usuario = new UsuarioRecord("João", "joao@email.com", 20);

Console.WriteLine($"\nUsuario original : {usuario}");

var usuariocopia = usuario with { Email = "jose@email.com" };

Console.WriteLine($"\nUsuario copia  : {usuariocopia}");

Console.WriteLine("\nApós alteração:");
Console.WriteLine($"Usuario original : {usuario}");

Console.ReadKey();

