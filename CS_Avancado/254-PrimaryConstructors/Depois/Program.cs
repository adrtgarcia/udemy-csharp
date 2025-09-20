
var clienteInvalido = new Cliente(null, ""); // 💥 ArgumentNullException!

Console.ReadKey();

public class Cliente(string nome, string email)
{
    public string Nome { get; } = nome ??
               throw new ArgumentNullException(nameof(nome));

    public string Email { get; } = !string.IsNullOrEmpty(email)
                ? email : throw new ArgumentException("Email inválido");

}