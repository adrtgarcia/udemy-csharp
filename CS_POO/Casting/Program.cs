Console.WriteLine("Operador Is e As");

/*
 
    o operador AS é usado para conversão de tipor de referência ou tipos anuláveis compatíveis
        - retorna NULL se não for possível (evita lançamento de exceção)
    
    downcasting (base > derivada):
        AS avalia o resultado para NULL ao invés de lançar exceção
 
 */

Object carroObj1 = new Carro();
try
{
    var x = (string)carroObj1;      // casting explícito
}
catch (Exception ex) 
{
    Console.WriteLine("\nA conversão falhou...\n");
    Console.WriteLine(ex.Message);
}

Object carroObj2 = new Carro();
var y = carroObj2 as string;
if (y != null)
    Console.WriteLine("\nconverteu obj > str");
else
    Console.WriteLine("y é null");

Circulo c1 = new();
Forma f = c1;                   // upcasting
Circulo c2 = f as Circulo;      // downcasting

if (c2 != null)
    c2.Exibir();
else
    Console.WriteLine("\ndowncasting inválido");

/*
 
    o operador IS é usado para verificar se o tipo de um objeto é compatível com
    o tipo especificado ou não, ou seja, se dá para fazer a conversão
        - retorna TRUE (mesmo tipo) ou FALSE (tipos diferentes ou NULL)

 */

Circulo circulo = new Circulo();
Forma forma = circulo;

if (forma is Circulo)
{
    Console.WriteLine("\nConverteu Forma > Circulo");
    // ((Circulo)forma).Exibir();
    var tipo = forma as Circulo;
    tipo?.Exibir();
}
else
    Console.WriteLine("\ndowncasting não possível");

class Carro { }
class Circulo : Forma { public void Exibir() { Console.WriteLine("\nexibindo círculo"); } }
class Forma { }