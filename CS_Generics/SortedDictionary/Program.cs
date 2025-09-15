Console.WriteLine("SortedDictionary<TKey, TValue>");

/*
 
    COLEÇÕES NÃO GENÉRICAS
        estão presentes no System.Collections e armazenam os elementos em arrays de objetos
        permitindo que eles contenham qualquer tipo de dados
            - ArrayList, HashTable, SortedList, Stack, Queue
        
        características:
            - armazenam dados do tipo Object
            - fazem a conversão implícita dos tipos de dados para Object
            - realizam boxing ao incluir e unboxing ao retirar elementos
            - são mais suscetíveis a exceções em tempo de execução devido a incompatibilidade entre tipos
 
    COLEÇÕES GENÉRICAS
        estão presentes no System.Collections.Generic, sendo coleções fortemente tipadas
            - Dictionary<TKey, TValue>, SortedDictionary<TKey, TValue>, SortedList<TKey, TValue>,
              LinkedList<T>, HashSet<T>, SortedSet<T>, Stack<T>, Queue<T>, List<T>

        características:
            - fortemente tipadas, evitando erros de incompatibilidade de tipo
            - não realizam boxing e unboxing, fornecendo melhor desempenho
            - facilitam a reutilização de código
 */

/*
 
    SortedDictionary<TKey, TValue> representa uma coleção do tipo chave/valor de forma ordenada
        - usa uma árvore binária para manter os itens em ordem pela chave
        - o tipo da palavra chave deve implementar a interface IComparable<TKey> de modo que
          as chaves possam ser corretamente ordenadas

    propriedades:
        - Count retorna o total de elementos
        - Item obtém/define o elemento com a chave especificada
        - Keys retorna a coleção de chaves
        - Values retorna a coleção de valores
        - Comparer obtém o comparador que determina a igualdade de chaves

    métodos:
        - Add adiciona um elemento no dicionário, lançando exceção se a chave já existir
        - Clear remove todos os elementos
        - ContainsKey determina se uma dada chave já existe
        - ContainsValue determina se um dado valor já existe
        - Remove remove o valor com a chave dada
        - TryGetValue obtém o valor associado à chave dada, e retorna um valor padrão se ela não existir
         
 */

Console.WriteLine("\ndeclarando e inicializando dicionário...");
SortedDictionary<int, string> sd = new()
{
    {1, "maria" },
    {2, "joão" },
    {3, "josé" }
};

Console.WriteLine("\nadicionando elementos...");

sd.Add(4, "ana");
sd.Add(5, "marina");

try
{
    Console.WriteLine("\ntentando adicionar chave repetida...");
    sd.Add(5, "pedro");
}
catch (Exception e)
{
    Console.WriteLine("essa chave já existe");
    Console.WriteLine("não foi possível adicionar o elemento\n");
    Console.WriteLine(e.Message);
    Console.WriteLine(e.ToString());
}

Console.WriteLine("\nexiste chave 6?");
if (!sd.ContainsKey(7))
{
    Console.WriteLine("não existe");
    Console.WriteLine("adicionando elemento...");
    sd.Add(6, "pedro");
}
else
{
    Console.WriteLine("já existe");
    Console.WriteLine("nenhum elemento foi adicionado...");
}

Console.WriteLine("\nacessando elementos...");
Console.WriteLine($"sd[1] = {sd[1]}");
Console.WriteLine($"sd[3] = {sd[3]}");
Console.WriteLine($"sd[5] = {sd[5]}");

Console.WriteLine("\nexiste elemento 'paulo'?");
if (sd.ContainsValue("paulo"))
{
    Console.WriteLine("já existe");
    Console.WriteLine("nenhum elemento foi adicionado...");
}
else
{
    Console.WriteLine("não existe");
    Console.WriteLine("adicionando elemento...");
    sd.Add(7, "paulo");
}

Console.WriteLine("\nalterando valor...");
Console.WriteLine($"sd[3] = {sd[3]}");
sd[3] = "mônica";
Console.WriteLine($"sd[3] = {sd[3]}");

Console.WriteLine("\ntentando ler chave inexistente...");
try
{
    Console.WriteLine($"sd[100] = {sd[100]}");
}
catch (Exception e)
{
    Console.WriteLine("sd[100] não existe\n");
    Console.WriteLine(e.Message);
    Console.WriteLine(e.ToString());
}

Console.WriteLine("\nrepetindo com o TryGetValue...");
if (sd.TryGetValue(100, out string? valor))
    Console.WriteLine($"sd[100] = {valor}");
else
    Console.WriteLine("sd[100] não existe");

Console.WriteLine("\npercorrendo o dicionário...");
foreach (var item in sd)
    Console.WriteLine($"{item.Key} - {item.Value}");
