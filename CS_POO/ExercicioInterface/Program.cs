Console.WriteLine("Exercício - Interface");

SalvarXml sx = new();
sx.Salvar();
sx.Nome();
// sx.Compactar();

SalvarJson sj = new();
sj.Salvar();
sj.Nome();
// sj.Compactar();

ISalvar isx = new SalvarXml();
isx.Compactar();

ISalvar isj = new SalvarJson();
isj.Compactar();

interface ISalvar
{
    public void Salvar();
    public void Compactar() { Console.WriteLine("compactando arquivo..."); }
}

public abstract class ArquivoBase
{
    public virtual void Nome() { }
}

public class SalvarXml : ArquivoBase, ISalvar
{
    public override void Nome()
    {
        Console.WriteLine("arquivo xml...");
    }
    public void Salvar()
    {
        Console.WriteLine("salvando xml...");
    }
}

public class SalvarJson : ArquivoBase, ISalvar
{
    public override void Nome()
    {
        Console.WriteLine("arquivo json...");
    }
    public void Salvar()
    {
        Console.WriteLine("salvando json...");
    }
}