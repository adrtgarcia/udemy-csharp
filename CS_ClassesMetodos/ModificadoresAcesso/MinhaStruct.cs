namespace ModificadoresAcesso;

internal struct MinhaStruct     /* padrão internal */
{
    int meuCampo;   /* padrão private */

    string? MinhaPropriedade { get; set; }  /* padrão private */

    void MeuMetodo()    /* padrão private */
    {
        Console.WriteLine("\nExecução do MeuMetodo() da MinhaStruct");
    }
}