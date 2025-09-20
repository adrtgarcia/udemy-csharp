namespace UsandoClass;

internal class UsuarioClass
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public int Idade { get; set; }

    public override string ToString()
        => $"{Nome}, {Email}, {Idade}";
}
