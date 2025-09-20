using System.Diagnostics.CodeAnalysis;

namespace Com_Delegates;

public sealed class ValidadorDeCliente
{
    //
    public delegate string? RegraDeValidacao(Cliente cliente);

    private readonly List<RegraDeValidacao> _regras = [];

    public ValidadorDeCliente AdicionarRegra(RegraDeValidacao regra)
    {
        ArgumentNullException.ThrowIfNull(regra);
        _regras.Add(regra);
        return this;
    }

    public bool Validar(Cliente cliente,
                        [NotNullWhen(returnValue: false)] out List<string>? erros)
    {
        if (cliente is null)
            throw new ArgumentNullException(nameof(cliente));

        // No início do método Validar
        erros = new List<string>(); // Sempre inicializa a lista

        foreach (var regra in _regras)
        {
            var erro = regra(cliente);
            if (!string.IsNullOrWhiteSpace(erro))
            {
                erros ??= [];
                erros.Add(erro);
            }
        }
        //
        return erros.Count == 0; // Verifica se a lista está vazia
    }
}