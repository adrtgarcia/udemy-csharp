Console.WriteLine("Herança - Encapsulamento");

ClasseDerivada c = new();
c.VerificarAcesso();

public class ClasseDerivada : ClasseBase
{
    public void VerificarAcesso()
    {
        PublicMembro();
        ProtectedMembro();
        ProtectedInternalMembro();
        InternalMembro();
        /* PrivateMembro();                 <- classe filha não tem acesso */

        Console.WriteLine(publicVar);
        Console.WriteLine(protectedVar);
        Console.WriteLine(internalVar);
        /* Console.WriteLine(privateVar);   <- acessamos campos private com propriedades */
        Console.WriteLine(PrivateVar);
    }
}

public class ClasseBase
{
    public int publicVar = 1;
    protected int protectedVar = 2;
    internal int internalVar = 3;
    private int privateVar = 4;   

    public int PrivateVar
    {
        get { return privateVar; }
        set { privateVar = value; }
    }

    public void PublicMembro()
    {
        Console.WriteLine("public ok");
    }
    protected void ProtectedMembro()
    {
        Console.WriteLine("protected ok");
    }
    protected internal void ProtectedInternalMembro()
    {
        Console.WriteLine("protected internal ok");
    }
    internal void InternalMembro()
    {
        Console.WriteLine("internal ok");
    }
    private void PrivateMembro()
    {
        Console.WriteLine("private ok");
    } 
}