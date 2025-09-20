
//ContadorNumeros(1, 2, 3, 4, 5);

//Console.ReadLine();

//static void ContadorNumeros(params int[] numeros)
//{
//    // Conta o número de elementos no array.
//    Console.WriteLine($"Número de elementos: {numeros.Length}");
//}

// **Exemplos de coleções aceitas diretamente:**
ContadorNumeros(new List<int> { 1, 2, 3 }); // List
ContadorNumeros(Enumerable.Range(6, 3));    // Qualquer Ienumerable
ContadorNumeros(new HashSet<int> { 4, 5 }); // HashSet
ContadorNumeros(new int[] { 9, 10 });       // Arrays ainda são aceitos

Console.ReadLine();

static void ContadorNumeros(params IEnumerable<int> numeros)
{
    Console.WriteLine($"Número de elementos: {numeros.Count()}");
}
