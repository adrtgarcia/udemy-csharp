Console.WriteLine("Indexadores");

/*
 
    Indexadores permitem que as instância de uma classe/struct sejam indexadas como um array
        - lembram as propriedades, mas seus get/set recebem parâmetros
        - ao definir um indexador para uma classe, ela se comporta como um array virtual

    public tipo this[lista de parâmetros]
    {
        get {...}
        set {...}
    }
 
 */

Time time = new Time();
time[1] = "praia clube";
time[3] = "sesi bauru";
time[5] = "sesc flamengo";
time[7] = "barueri";
time[-1] = "osasco";
time[1000] = "gerdau minas";

string valor1 = time[1];
string valor2 = time[3];
string valor3 = time[5];
string valor4 = time[7];
string valor5 = time[-1];
string valor6 = time[1000];

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);

public class Time
{
    string[] valor = new string[10];
    public string this[int i]
    {
        get
        {
            if (i >= 0 && i < valor.Length) 
                return valor[i];
            return "Erro";
        }
        set
        {
            if (i >= 0 && i < valor.Length) 
                valor[i] = value;
        }
    }
}