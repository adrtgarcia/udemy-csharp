Console.WriteLine("List e IEnumerable");

/*
 
    Principais métodos de consultas LINQ
        - Any(): determina se qualquer elemento existe/atende a condição
        - FirstOrDefaut(): retorna o primeiro elemento da colução que satisfaz a condição
        - OrderBy(): classifica os elementos em ordem crescente com base na condição
        - ToList(): converte IEnumerable em List
        - Where(): retorna todos os elementos que atendem a condição
 
 */

/*
 
    IEnumerable (interface) descreve um comportamento
        - read-only
        - retorna o próximo item da coleção, não precisa ter toda a coleção na memória, não sabe quantos
          elementos estão na coleção e ao ser iterada com foreach vai retornando o próximo item até o fim da coleção
        - permite que o compilador adiar a execução
        - só executa ao ser iterada ou ter um valor extraído
        - mais indicada para poucas consultas e acessos (faz várias avaliações)

    List (classe concreta) implementa esse comportamento
        - pode ser acessada e alterada
        - possui toda a coleção na memória e sabe quantos elementos ela tem
        - mais indicada para quando se tem muita manipulação dos dados (faz uma única avaliação)
 
 */

var limiteCredito = new List<Limite>();
for (int i = 1; i <= 16; i++) limiteCredito.Add(new Limite() { Numero = i });

Console.WriteLine("\nCom IEnumerable");
var limitesComRestricao = limiteCredito.Where(x => x.AnalisarLimite());     // elementos serão avaliados apenas se iterados
if (limitesComRestricao.Count() > 3)
{
    Console.WriteLine("\n\nHá mais de 3 limites com restrição");
}

if (limitesComRestricao.Count() > 5)
{
    Console.WriteLine("\n\nHá mais de 3 limites com restrição");
}

Console.WriteLine("\nCom List");
limitesComRestricao.ToList();
if (limitesComRestricao.Count() > 3)
{
    Console.WriteLine("\n\nHá mais de 3 limites com restrição");
}

if (limitesComRestricao.Count() > 5)
{
    Console.WriteLine("\n\nHá mais de 3 limites com restrição");
}

public class Limite
{
    public int Numero { get; set; }
    private bool ehRestricao;

    public Limite()
    {
        var semente = Guid.NewGuid().GetHashCode();
        var numeroAleatorio = new Random(semente).Next(1, 4);
        ehRestricao = numeroAleatorio == 1;
    }

    public bool AnalisarLimite()
    {
        Console.WriteLine("\nAnálise de crédito: " + Numero);
        return ehRestricao;
    }
}