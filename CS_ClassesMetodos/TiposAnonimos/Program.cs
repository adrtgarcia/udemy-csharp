Console.WriteLine("Tipos anônimos");

/*
 
 tipo anônimo é um tipo (classe) sem nenhum nome que pode conter apenas propriedades públicas somente leitura
    - fornece uma maneira conveniente para encapsular um conjunto de propriedades somente leitura em um único objeto sem precisar primeiro definir explicitamente um tipo
    - o nome do tipo é gerado pelo compilador e não está disponível no código-fonte
    - o tipo de cada propriedade é inferido pelo compilador

 sintaxe:
    var nomeTipo = new 
    {
        Campo1 = valor1,
        Campo2 = valor2
    };
 
 */

var aluno1 = new
{
    Nome = "Maria",
    Idade = 18
};

Console.WriteLine(aluno1.Nome + ", " + aluno1.Idade + " anos");

/* aluno1.Idade = 20;  <- compilador não permite (read-only) */

Console.WriteLine(aluno1.GetType().ToString());

var aluno2 = new
{
    Id = 123,
    Nome = "João",
    Email = "joão@email.com",
    Endereco = new
    {
        Id = 456,
        Cidade = "Uberlândia",
        Pais = "Brasil"
    }
};

Console.WriteLine(aluno2.Nome + ", " + aluno2.Endereco.Cidade);

var alunos = new[]
{
    new { Id = 1, Nome = "Maria", Email = "maria@email.com"},
    new { Id = 2, Nome = "João", Email = "joao@email.com"},
    new { Id = 3, Nome = "Ana", Email = "ana@email.com"}
};

Console.WriteLine(alunos[0].Nome + ", " + alunos[0].Email);
Console.WriteLine(alunos[1].Nome + ", " + alunos[1].Email);
Console.WriteLine(alunos[2].Nome + ", " + alunos[2].Email);