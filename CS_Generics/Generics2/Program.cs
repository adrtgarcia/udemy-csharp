using System.Collections;

Console.WriteLine("Generics");
Console.WriteLine("\nSegurança de dados");

ArrayList lista = new ArrayList
{  
    50,                         // cast boxing
    "Generics",                 // cast boxing 
    new Aluno()                 // cast boxing
};
foreach (var item in lista) 
{ 
    Console.WriteLine(item);     // unboxing
}

ClasseGenerica<int> intObj = new();
intObj.Adicionar(10);
intObj.Adicionar(20);
intObj.Adicionar(30);
intObj.Adicionar(40);
intObj.Adicionar(50);
for (int i = 0; i < 5; i++) Console.WriteLine(intObj[i]);

Console.WriteLine("\nAnálise de desempenho e reutilização");
ArrayList obj = new();
obj.Add(50);                    // boxing
int x = (int)obj[0];            // unboxing
foreach (int i in obj)
{
    Console.WriteLine(i);       // unboxing
}

ClasseGenerica<int> intObj2 = new();
intObj2.Adicionar(50);
ClasseGenerica<string> strObj = new();
strObj.Adicionar("Generics");
ClasseGenerica<Aluno> aluObj = new();
aluObj.Adicionar(new Aluno { Nome = "Maria"} );

public class Aluno 
{
    public string? Nome { get; set; }
}

public class ClasseGenerica<T> 
{
    T[] obj = new T[5];
    int contador = 0;
    public void Adicionar(T item)
    {
        if (contador < 5) 
        {
            obj[contador] = item;
            contador++;
        }       
    }
    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}
