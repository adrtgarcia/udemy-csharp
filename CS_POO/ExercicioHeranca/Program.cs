Console.WriteLine("Exercício - Herança");

ContaCorrente cc = new();
cc.Numero = 123;
cc.NomeCliente = "Maria";
cc.Depositar(1000);
cc.Sacar(120);
cc.ExibirSaldo();

ContaPoupanca cp = new();
cp.Numero = 456;
cp.NomeCliente = "João";
cp.Depositar(1000);
cp.Sacar(120);
cp.ExibirSaldo();

ContaInvestimento ci = new();
ci.Numero = 789;
ci.NomeCliente = "José";
ci.Depositar(1000);
ci.Sacar(120);
ci.ExibirSaldo();

public class ContaCorrente
{
    public int Numero { get; set; }
    public string? NomeCliente { get; set; }
    public double Saldo { get; set; } = 0.00;

    public virtual double Depositar(double valor)
    {
        Saldo += valor;
        return Saldo;
    }
    public virtual double Sacar(double valor)
    {
        Saldo -= valor;
        return Saldo;
    }
    public void ExibirSaldo()
    {
        Console.WriteLine($"Conta {Numero} - R$ {Saldo.ToString("c")}");
    }
}

public class ContaPoupanca : ContaCorrente
{
    public double JurosMensais { get; set; } = 0.005;

    public override double Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            return Saldo;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente...");
            return Saldo;
        }
    }

    public override double Depositar(double valor)
    {
        Saldo = Saldo + valor + (Saldo * JurosMensais);
        return Saldo;
    }
}

public class ContaInvestimento : ContaCorrente
{
    public double TaxaRemuneracao { get; set; } = 0.009;
    public double TaxaImposto { get; set; } = 0.001;

    public override double Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo = Saldo - valor - (Saldo * TaxaImposto);
            return Saldo;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente...");
            return Saldo;
        }
    }

    public override double Depositar(double valor)
    {
        Saldo = Saldo + valor + (Saldo * TaxaRemuneracao);
        return Saldo;
    }
}