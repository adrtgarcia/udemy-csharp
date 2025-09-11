namespace ModificadoresAcesso;

internal class MinhaClasse  /* padrão internal */
{
    int meuCampo;   /* padrão private */

    string? MinhaPropriedade { get; set; }  /* padrão private */

    void MeuMetodo()    /* padrão private */
    {
        Console.WriteLine("\nExecução do MeuMetodo()");
    }
}