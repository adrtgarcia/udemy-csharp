Console.WriteLine("Queue<T>");

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
 
    Queue<T> é uma coleção genérica que aplica o princípio FIFO, além de aceitar valores repetidos e NULL
        - elementos são adicionados com Enqueue() e recuperados com Dequeue() e Peek()
        - não é possível usar a sintaxe do inicializador de coleção e não fornece suporte a um indexador

    propriedade:
        - Count retorna o total de elementos na pilha
    
    métodos:
        - Enqueue inclui um novo elemento no fim da fila
        - Dequeue remove e retorna o elemento no início da fila
        - Peek retorna o elemento no início da fila sem removê-lo
        - Contains verifica se existe um dado elemento na fila (true/false)
        - Clear remove todos os elementos da fila
        
 */

Queue<string> diasSemana = new();
diasSemana.Enqueue("segunda");
diasSemana.Enqueue("terça");
diasSemana.Enqueue("quarta");

List<int> listaPares = new() { 2, 4, 6, 8 };
Queue<int> pares = new(listaPares);

Queue<string> alunos = new(5);
alunos.Enqueue("maria");
alunos.Enqueue("joão");
alunos.Enqueue("ana");
alunos.Enqueue("josé");

foreach (var aluno in alunos) Console.Write(aluno + "\t");
Console.WriteLine($"\ntotal de alunos: {alunos.Count}");

Console.WriteLine("\naplicando os métodos na queue alunos...\n");
Console.WriteLine("\nadicionando novo nome...");
alunos.Enqueue("paula");
foreach (var aluno in alunos) Console.Write(aluno + "\t");
Console.WriteLine($"\ntotal de alunos: {alunos.Count}");

Console.WriteLine("\nremovendo nome...");
var removido = alunos.Dequeue();
Console.WriteLine($"nome removido: {removido}");
foreach (var aluno in alunos) Console.Write(aluno + "\t");
Console.WriteLine($"\ntotal de alunos: {alunos.Count}");

Console.WriteLine("\nrecuperando nome no início com peek...");
var nome = alunos.Peek();
Console.WriteLine($"nome recuperado: {nome}");
foreach (var aluno in alunos) Console.Write(aluno + "\t");
Console.WriteLine($"\ntotal de alunos: {alunos.Count}");

Console.WriteLine($"\nalunos contém 'maria'? {alunos.Contains("maria")}");

Console.WriteLine("\nremovendo todos os elementos da fila...");
alunos.Clear();
foreach (var aluno in alunos) Console.Write(aluno + "\t");
Console.WriteLine($"\ntotal de alunos: {alunos.Count}");
