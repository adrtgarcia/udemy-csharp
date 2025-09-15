using ExcecaoPersonalizada3;

Console.WriteLine("Exemplo - Exceções Personalizadas");

Conta c1 = new(100, "Maria", 500.00m);
Console.WriteLine(c1.ToString() + "\n");

Console.WriteLine($"Saldo: {c1.Depositar(150.00m).ToString("c")}\n");
Console.WriteLine($"Saldo: {c1.Sacar(345.50m).ToString("c")}\n");

Console.WriteLine(c1.ToString());

try
{
    Console.WriteLine("\nDepositando um valor negativo...");
    Console.WriteLine($"\nSaldo: {c1.Depositar(-50.00m).ToString("c")}");
}
catch (DepositoNegativoException e)
{
    Console.WriteLine($"\nERRO: {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"\nERRO: {e.Message}");
}

try
{
    Console.WriteLine("\nSacando um valor maior que o saldo...");
    Console.WriteLine($"\nSaldo: {c1.Sacar(1000.00m)}");
}
catch (SaldoInsuficienteException e)
{
    Console.WriteLine($"\nERRO: {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"\nERRO: {e.Message}");
}

public class Conta
{
    public int Numero { get; set; }
    public string? Titular { get; set; }
    public decimal Saldo { get; set; }

    public Conta(int numero, string? titular, decimal saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }

    public decimal Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Valor do depósito: {valor.ToString("c")}");
        }
        else
        {
            Console.WriteLine("Valor do depósito deve ser maior que R$ 0,00");
            throw new DepositoNegativoException();
        }
        return Saldo;
    }
    public decimal Sacar(decimal valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Valor do saque: {valor.ToString("c")}");
        }
        else
        {
            Console.WriteLine($"Valor do saque não pode ser maior que {Saldo.ToString("c")}");
            throw new SaldoInsuficienteException(valor, Saldo);
        }
        return Saldo;
    }
    public override string ToString()
    {
        return ($"\nConta: {Numero}\tTitular: {Titular}\t\tSaldo: {Saldo.ToString("c")}");
    }
}
