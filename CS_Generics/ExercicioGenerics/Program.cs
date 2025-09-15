Console.WriteLine("Exercício - Generics");

Generica<int> numeros = new();

numeros.Adicionar(1);
numeros.Adicionar(2);
numeros.Adicionar(3);
numeros.Adicionar(4);
numeros.Adicionar(5);
/* vet.Adicionar("maria")          <- segurança de tipo: precisa ser do tipo T especificado */

for (int i = 0; i < 5; i++) Console.WriteLine(numeros[i]);

Generica<string> nomes = new(); /* <- reaproveitamento de código */

nomes.Adicionar("maria");
nomes.Adicionar("joão");
nomes.Adicionar("josé");

for (int i = 0; i < 5; i++) Console.WriteLine(nomes[i]);


public class Generica<T>
{
    T[] vetor = new T[5];
    int contador = 0;
    public void Adicionar(T objeto) 
    {
        if (contador < 5)
        {
            vetor[contador] = objeto;
            contador++;
        } 
        else 
            Console.WriteLine("o limite do vetor foi atingido");
    }
    public T this[int index]
    {
        get { return vetor[index]; }
        set { vetor[index] = value; }
    }
}
