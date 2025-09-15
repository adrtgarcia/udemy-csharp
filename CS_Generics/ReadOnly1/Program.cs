using System.Collections.ObjectModel;

Console.WriteLine("ReadOnlyCollection<T>");

/*
 
    Coleções somente leitura são estruturas de dados do System.Collections.ObjectModel 
    que permitem que os dados sejam acessados, mas não modificados.
 
    ReadOnlyCollection<T>
        - fornece a classe base para uma coleção somente leitura genérica
        - criada a partir de uma coleção mutável (array, list)

    ReadOnlyDictionary<T>
        - representa uma coleção somente leitura genérica de pares chave-valor
        - criada a partir de um dicionário mutável

 */

/*
 
    ReadOnlyCollection<T>
        propriedades: 
            - Count retorna o número de elementos
            - Item[] retorna o elemento em uma dada posição
            - Items retorna a IList<T> que a coleção envolve
 
        métodos:
            - Contains determina se um elemento está na coleção (true/false)
            - CopyTo copia copia os dados para um array unidimensional compatível
            - GetEnumerator retorna um enumerador que itera pela coleção
            - IndexOf pesquisa o objeto e retorna o índice da sua primeira ocorrência
                * faz uma pesquisa linear e determina a igualdade por meio do 
                  comparador padrão EqualityComparer<T>.Default

 */

List<string> planetas = new()
{
    "mercúrio", "vênus", "terra", "marte"
};

ReadOnlyCollection<string> listaPlanetas = new(planetas);

Console.WriteLine("\nlista de planetas:");
foreach (string planeta in listaPlanetas) Console.Write(planeta + "  ");
Console.WriteLine("\n");

List<string> alunos = new()
{
    "maria", "ana", "joão", "josé"
};

var listaAlunos = alunos.AsReadOnly();
/* ReadOnlyCollection<string> listaAlunos = alunos.AsReadOnly(); */

Console.WriteLine("\nlista de alunos:");
foreach (string aluno in listaAlunos) Console.Write(aluno + "  ");
Console.WriteLine("\n");

Console.WriteLine("\n\n");
Console.WriteLine("aplicando propriedades e métodos na coleção de planetas...");
foreach (string planeta in listaPlanetas) Console.Write(planeta + "  ");
Console.WriteLine($"\nnúmero de planetas: {listaPlanetas.Count}");

Console.WriteLine($"\n'terra' está na coleção? {listaPlanetas.Contains("terra")}");
Console.WriteLine($"'júpiter' está na coleção? {listaPlanetas.Contains("júpiter")}");

Console.WriteLine($"\nelemento no índice 1: {listaPlanetas[1]}");
Console.WriteLine($"elemento no índice 3: {listaPlanetas[3]}");

Console.WriteLine($"\níndice de 'mercúrio': {listaPlanetas.IndexOf("mercúrio")}");
Console.WriteLine($"índice de 'vênus': {listaPlanetas.IndexOf("vênus")}");

/* 
    não é possível adicionar/remover elementos de uma coleção read-only, 
    mas é possível alterar a coleção que deu origem a ela
*/

Console.WriteLine("\nalterando a lista original...");
planetas.Insert(4, "plutão");
Console.WriteLine("'plutão' foi adicionado à lista original");
Console.WriteLine("imprimindo a coleção read-only...");
foreach (string planeta in listaPlanetas) Console.Write(planeta + "  ");
Console.WriteLine($"\nnúmero de planetas: {listaPlanetas.Count}");

Console.WriteLine("\ncopiando a coleção read-only para um array");
string[] arrayPlanetas = new string[listaPlanetas.Count + 2];
listaPlanetas.CopyTo(arrayPlanetas, 1);
Console.WriteLine("imprimindo conteúdo do novo array");
foreach (string planeta in arrayPlanetas) Console.Write($"[ {planeta} ]  ");
Console.WriteLine($"\nnúmero de elementos: {arrayPlanetas.Length}");
