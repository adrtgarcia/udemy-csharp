Console.WriteLine("HashSet<T>");

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
 
    SET é uma coleção que contém apenas itens distintos
        - HashSet<T> contém uma lista não ordenada, é mais rápida para adicionar e remover elementos
        - SortedSet<T> contém uma lista ordenada, é mais rápida para localizar elementos
 
 */

/*
 
    HashSet<T> implementa a interface ISet<T> e usa uma função hash para determinar a posição de um item,
    permitindo seu rápido acesso
        - não garante nenhuma ordem dos elementos, e a ordem pode mudar com a inclusão/remoção de itens
        - ISet<T> oferece métodos para criar união de múltiplos conjuntos, criar interseção de conjuntos,
          ou para fornecer informações se um conjunto for um superconjunto ou subconjunto de outro
 
    propriedades:
        - Count retorna o número de itens
        - Comparer retorna o objeto IEqualityComparer<T> que determina a igualdade dos elementos

    métodos:
        - Add adiciona um item que não está no conjunto (retorna true/false)
        - Contains verifica se um item está no conjunto (retorna true/false)
        - Remove remove um item do conjunto (retorna true/false)
        - ExceptWith remove todos os elementos na coleção especificada
        - IntersectWith modifica o conjunto para que tenha apenas elementos de um dado objeto/coleção
        - IsSubsetOf determina se um conjunto é subconjunto de uma dada coleção
        - Overlaps determina se um conjunto e uma dada coleção compartilham elementos
        - RemoveWhere remove todos os elementos que correspondem às condições do predicado
        - SetEquals determia se um conjunto e uma dada coleção contêm os mesmos elementos
        - SymmetricExceptWith modifica o conjunto para que contenha apenas elementos dele ou de uma dada coleção
        - UnionWith modifica o conjunto para que contenha elementos que estão nele e em uma dada coleção
 
 */

HashSet<int> numeros = new() { 1, 2, 3, 4, 5 };
HashSet<string> nomes = new() { "maria", "joão", "josé" };

HashSet<int> pares = new();
for (int i = 0; i < 6; i++) pares.Add(i * 2);

List<double> listaNotas = new() { 4.5, 4.2, 3.8, 3.9 };
HashSet<double> setNotas = new(listaNotas);

HashSet<string> timeSp = new() { "Santos", "Palmeiras", "São Paulo" };
HashSet<string> timeRj = new() { "Vasco", "Fluminense", "Botafogo" };
HashSet<string> timeBa = new() { "Bahia", "Vitória", "Juazeiro" };
HashSet<string> times = new() { "Santos", "Palmeiras", "São Paulo" };

if (timeSp.Add("Corinthians")) Console.WriteLine("\ntime adicionado");
if (!timeRj.Contains("Flamengo"))
{
    timeRj.Add("Flamengo");
    Console.WriteLine("time adicionado");
}

if (timeBa.Contains("Juazeiro"))
{
    timeBa.Remove("Juazeiro");
    Console.WriteLine("time removido");
}

if (timeSp.IsSubsetOf(times)) Console.WriteLine("\ntimesp é subset de times");
else Console.WriteLine("\ntimesp não é subset de times");

if (times.IsSupersetOf(timeRj)) Console.WriteLine("\ntimes é superset de timerj");
else Console.WriteLine("\ntimes não é superset de timerj");

if (timeSp.SetEquals(timeRj)) Console.WriteLine("\ntimesp é igual a timerj");
else Console.WriteLine("\ntimesp é diferente de timerj");

Console.WriteLine("\njuntando todos os sets em times");
times.UnionWith(timeSp);
times.UnionWith(timeRj);
times.UnionWith(timeBa);
foreach (var t in times) Console.Write($"{t}\t\t");
