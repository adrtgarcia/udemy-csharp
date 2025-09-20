namespace Sem_Delegates;

public class ValidadorDeCliente
{
    public bool Validar(Cliente cliente, out List<string> erros)
    {
        // 1. Inicializa a lista de erros.
        erros = new List<string>();

        // 2. Executa cada validação e adiciona o erro à lista, sem parar a execução.
        if (string.IsNullOrWhiteSpace(cliente.Nome))
        {
            erros.Add("Erro: Nome é obrigatório.");
        }
        
        // Usamos 'else if' para não checar o tamanho de um nome que já é nulo.
        if (cliente.Nome!.Length < 5)
        {
            erros.Add("Erro: Nome deve ter no mínimo 5 caracteres.");
        }

        // A verificação de e-mail pode ser feita de forma independente.
        if (cliente.Email == null || !cliente.Email.Contains("@"))
        {
            erros.Add("Erro: E-mail inválido.");
        }

        // A verificação de idade também é independente.
        if (cliente.Idade < 21)
        {
            erros.Add("Erro: Cliente deve ter no mínimo 21 anos.");
        }

        // 3. O resultado final da validação é se a lista de erros está vazia ou não.
        return erros.Count == 0;
    }
}
