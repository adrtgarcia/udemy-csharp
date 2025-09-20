namespace CallerArgumentExpressionDemo;

public static class Validador
{
    public static void NotNullOrEmpty(string valor, string nome)
    {
        if (string.IsNullOrWhiteSpace(valor))
            throw new ArgumentException("O valor não pode ser nulo ou vazio.", nome);
    }

    public static void MaiorQueZero(decimal valor, string nome)
    {
        if (valor <= 0)
            throw new ArgumentOutOfRangeException(nome, "O valor deve ser maior que zero.");
    }

    public static void MaiorQueZero(int valor, string nome)
    {
        if (valor <= 0)
            throw new ArgumentOutOfRangeException(nome, "O valor deve ser maior que zero.");
    }
}
