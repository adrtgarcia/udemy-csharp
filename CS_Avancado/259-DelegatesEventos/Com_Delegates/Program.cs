using Com_Delegates;

Console.WriteLine("\n ### Exemplo de validação usando Delegates ###\n");
Console.ReadKey();

Console.WriteLine("\nValidando cliente : Zé - email#hotmail.com - 19 anos\n");

var cliente = new Cliente("Zé", "email‑invalido", 19);

// Aqui poderiamos criar uma classe contendo as regras de validação.
// Ex: RegrasValidacaoCliente
var validador = new ValidadorDeCliente()
    .AdicionarRegra(c => string.IsNullOrWhiteSpace(c.Nome) ? "Nome é obrigatório." : null)
    .AdicionarRegra(c => c.Nome!.Length < 5 ? "Nome deve ter no mínimo 5 caracteres." : null)
    .AdicionarRegra(c => !c.Email!.Contains('@') ? "E‑mail inválido." : null)
    .AdicionarRegra(c => c.Idade < 21 ? "Cliente deve ser maior de idade." : null);

if (!validador.Validar(cliente, out var erros))
{
    Console.WriteLine("Cliente inválido. Erros encontrados:");

    Console.ForegroundColor = ConsoleColor.Red;
    foreach (var e in erros)
        Console.WriteLine($"- {e}");
    Console.ResetColor();
}

Console.WriteLine("\nProcesso concluído. Pressione algo para sair.");
Console.ReadKey();