Console.WriteLine("Stack<T>");

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
 
    Stack<T> é uma coleção genérica que aplica o princípio LIFO, além de aceitar valores repetidos e NULL
        - é útil quando se precisa de armazenamento temporário para obter informações, ou seja, quando 
          se quer descartar um elemento depois de recuperar seu valor
        - elementos são adicionados com Push() e recuperados com Pop() e Peek()
        - não é possível usar a sintaxe do inicializador de coleção e não fornece suporte a um indexador
        - capacidade de uma Stack<T> é o número de elementos que ela pode conter

    propriedade:
        - Count retorna o total de elementos na pilha
    
    métodos:
        - Push inclui um novo elemento no topo da pilha
        - Pop remove e retorna o elemento no topo da pilha
        - Peek retorna o elemento no topo da pilha sem removê-lo
        - Contains verifica se existe um dado elemento na pilha (true/false)
        - Clear remove todos os elementos da pilha
        - ToArray copia e pilha em um novo array unidimensional

 */

Stack<string> diasSemana = new();   
diasSemana.Push("segunda");
diasSemana.Push("terça");
diasSemana.Push("quarta");

List<int> listaPares = new() { 2, 4, 6, 8 };
Stack<int> pares = new(listaPares);          

Stack<string> alunos = new(5);    
alunos.Push("maria");
alunos.Push("joão");
alunos.Push("ana");
alunos.Push("josé");

foreach (var aluno in alunos) Console.Write(aluno + "\t");
Console.WriteLine($"\ntotal de alunos: {alunos.Count}");

Console.WriteLine("\naplicando os métodos na stack alunos...\n");
Console.WriteLine("\nadicionando novo nome...");
alunos.Push("paula");
foreach (var aluno in alunos) Console.Write(aluno + "\t");
Console.WriteLine($"\ntotal de alunos: {alunos.Count}");

Console.WriteLine("\nremovendo nome...");
var removido = alunos.Pop();
Console.WriteLine($"nome removido: {removido}");
foreach (var aluno in alunos) Console.Write(aluno + "\t");
Console.WriteLine($"\ntotal de alunos: {alunos.Count}");

Console.WriteLine("\nrecuperando nome no topo com peek...");
var nome = alunos.Peek();
Console.WriteLine($"nome recuperado: {nome}");
foreach (var aluno in alunos) Console.Write(aluno + "\t");
Console.WriteLine($"\ntotal de alunos: {alunos.Count}");

Console.WriteLine($"\nalunos contém 'maria'? {alunos.Contains("maria")}");

Console.WriteLine("\npassando a stack para um array...");
var arrayAlunos = alunos.ToArray();
foreach (var aluno in arrayAlunos) Console.Write(aluno + "\t");
Console.WriteLine($"\ntotal de alunos: {arrayAlunos.Length}");

Console.WriteLine("\nremovendo todos os elementos da stack...");
alunos.Clear();
foreach (var aluno in alunos) Console.Write(aluno + "\t");
Console.WriteLine($"\ntotal de alunos: {alunos.Count}");
