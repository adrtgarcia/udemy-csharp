Console.WriteLine("Dictionary<TKey, TValue>");

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
 
    Dictionary<TKey, TValue> representa uma coleção do tipo chave/valor e implementa a interface
    IDictionary que possui duas coleções no seu interior, uma para guarda a chave e a outra, o valor
        - requer uma implementação de igualdade para determinar se as chaves são iguais
        - é possível especificar uma implementação da interface genérica IEqualityComparer<T> usando    
          um construtor que aceita um parâmetro de comparação

    propriedades:
        - Count retorna o total de elementos
        - IsReadOnly retorna um bool indicando se o dicionário é read-only
        - Item obtém/define o elemento com a chave especificada
        - Keys retorna a coleção de chaves
        - Values retorna a coleção de valores
        - Comparer obtém o comparador que determina a igualdade de chaves

    métodos:
        - Add adiciona um elemento no dicionário, lançando exceção se a chave já existir
        - TryAdd tenta adicionar um elemento novo, retorna true/false
        - Clear remove todos os elementos
        - ContainsKey determina se uma dada chave já existe
        - ContainsValue determina se um dado valor já existe
        - Remove remove o valor com a chave dada
        - TryGetValue obtém o valor associado à chave dada, e retorna um valor padrão se ela não existir
         
 */

Console.WriteLine("\ndeclarando e inicializando dicionário...");
Dictionary<int, int> d1 = new() 
{
    {1, 100 },
    {2, 200 },
    {3, 200 }
};

Console.WriteLine("\nadicionando elementos...");

d1.Add(9, 400);
d1.Add(5, 500);

try
{
    Console.WriteLine("\ntentando adicionar chave repetida...");
    d1.Add(3, 300);
}
catch (Exception e)
{
    Console.WriteLine("essa chave já existe");
    Console.WriteLine("não foi possível adicionar o elemento\n");
    Console.WriteLine(e.Message);
    Console.WriteLine(e.ToString());
}

Console.WriteLine("\nusando TryAdd()...");
Console.WriteLine($"6-300: {d1.TryAdd(6, 300)}");
Console.WriteLine($"3-300: {d1.TryAdd(3, 300)}");

Console.WriteLine("\nexiste chave 7?");
if(!d1.ContainsKey(7))
{
    Console.WriteLine("não existe");
    Console.WriteLine("adicionando elemento...");
    d1.Add(7, 700);
}
else
{
    Console.WriteLine("já existe");
    Console.WriteLine("nenhum elemento foi adicionado...");
}

Console.WriteLine("\nacessando elementos...");
Console.WriteLine($"d1[1] = {d1[1]}");
Console.WriteLine($"d1[3] = {d1[3]}");
Console.WriteLine($"d1[5] = {d1[5]}");

Console.WriteLine("\nexiste elemento 300?");
if(d1.ContainsValue(300))
{
    Console.WriteLine("já existe");
    Console.WriteLine("nenhum elemento foi adicionado...");
}
else
{
    Console.WriteLine("não existe");
    Console.WriteLine("adicionando elemento...");
    d1.Add(8, 300);
}

Console.WriteLine("\nalterando valor...");
Console.WriteLine($"d1[3] = {d1[3]}");
d1[3] = 1000;
Console.WriteLine($"d1[3] = {d1[3]}");

Console.WriteLine("\ntentando ler chave inexistente...");
try
{
    Console.WriteLine($"d1[100] = {d1[100]}");
}
catch (Exception e)
{
    Console.WriteLine("d1[100] não existe\n");
    Console.WriteLine(e.Message);
    Console.WriteLine(e.ToString());
}

Console.WriteLine("\nrepetindo com o TryGetValue...");
if (d1.TryGetValue(100, out int valor))
    Console.WriteLine("d1[100] = {valor}");
else
    Console.WriteLine("d1[100] não existe");

Console.WriteLine("\npercorrendo o dicionário...");
foreach(var item in d1) 
    Console.WriteLine($"{item.Key} - {item.Value}");

Console.WriteLine("\nordenando o dicionário com SortedDictionary...");
var d1Ord1 = new SortedDictionary<int, int>(d1);
foreach (var item in d1Ord1) 
    Console.WriteLine($"{item.Key} - {item.Value}");

Console.WriteLine("\nordenando o dicionário com LINQ...");
var d1Ord2 = d1.OrderBy(x => x.Key);
foreach (var item in d1Ord2) 
    Console.WriteLine($"{item.Key} - {item.Value}");
