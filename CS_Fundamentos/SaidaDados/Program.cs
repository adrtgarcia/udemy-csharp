Console.WriteLine("Formatação da Saída de Dados");

int idade = 25;
string nome = "Maria";

Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine();

Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos ");
Console.WriteLine();

// concatenação
Console.WriteLine(nome + " tem " + idade + " anos ");
Console.WriteLine();

// interpolação <- mais indicado
Console.WriteLine($"{nome} tem {idade} anos");
Console.WriteLine();

// place holders <- menos utilizado
Console.WriteLine("{0} tem {1} anos", nome, idade);
Console.WriteLine();

// sequências de escape (\n, \t, \\, \', \", \?)
string frase = "Ele falou: \"Não fui eu\"";
Console.WriteLine(frase);
Console.WriteLine();

Console.WriteLine("Pizza\n" + "de\n" + "Calabresa\n");
Console.WriteLine("Bolo\t" + "de\t" + "Chocolate\t");