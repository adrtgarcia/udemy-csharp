Console.WriteLine("SortedSet<T>");

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
 
    HashSet<T> implementa a interface ISet<T> e usa SortedSet<T>.Comparer para garantir a ordem correta dos itens
        - a ordem é garantida pela implementação de IComparer<T>, que compara os elementos entre si
        - ISet<T> oferece métodos para criar união de múltiplos conjuntos, criar interseção de conjuntos,
          ou para fornecer informações se um conjunto for um superconjunto ou subconjunto de outro
 
    propriedades:
        - Count retorna o número de itens
        - Comparer retorna o objeto IEqualityComparer<T> que determina a igualdade dos elementos
        - Max obtém o maior valor (definido pelo comparador)
        - Min obtém o menor valor (definido pelo comparador) 

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

var numeros = new List<int>() { 1, 7, 3, 6, 5, 4, 2 };
SortedSet<int> setNum = new(numeros);
foreach (var n in setNum) Console.Write($"{n}  ");
Console.WriteLine();

var frutas = new List<string> { "uva", "morango", "maracujá", "morango" };
SortedSet<string> setFru = new(frutas);
foreach (var f in setFru) Console.Write($"{f}  ");
Console.WriteLine();

SortedSet<int> setPar = new();
for (int i = 0; i < 10; i = i + 2) setPar.Add(i);
foreach (var p in setPar) Console.Write($"{p}  ");
Console.WriteLine();
