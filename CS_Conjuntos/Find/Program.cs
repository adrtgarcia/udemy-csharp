Console.WriteLine("Métodos Find");

/* 
 
    - Find(): retorna o primeiro elemento correspondente ao predicado
    - FindLast(): retorna o último elemento correspondente ao predicado
    - FindIndex(): retorna o índice do primeiro elemento correspondente ao predicado
    - FindLastIndex(): retorna o índice do último elemento correspondente ao predicado
    - FindAll(): retorna todos os elementos correspondentes ao predicado

    Predicado: 
        Função/Método de argumento único que retorna um valor booleano
 
 */

List<string> nomes = new() { "maria", "joão", "josé", "ana" };
foreach (string nome in nomes) Console.Write(nome + " - ");

var nome1 = nomes.Find(ProcurarNome);
Console.WriteLine("\nFind(): " + nome1);

var nome2 = nomes.FindLast(ProcurarNome);
Console.WriteLine("FindLast(): " + nome2);

var nome3 = nomes.FindIndex(i=>i.StartsWith('j'));
Console.WriteLine("FindIndex(): " + nome3);

var nome4 = nomes.FindLastIndex(i => i.StartsWith('j'));
Console.WriteLine("FindLastIndex(): " + nome4);

var nome5 = nomes.FindAll(i => i.EndsWith('a'));
Console.Write("FindAll(): ");
foreach (string nome in nome5) Console.Write(nome + " - ");

static bool ProcurarNome(string nome)
{
    return nome.Contains('a');
}

/*

    Ao invés de definir o predicado como função, 
    podemos usar Expressão Lambda (Função Anônima):
        parâmetros de entrada => instruções
 
 */
