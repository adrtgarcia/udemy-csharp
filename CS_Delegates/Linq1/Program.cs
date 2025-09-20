Console.WriteLine("Language Integrated Query (LINQ)");

/*
 
    LINQ é um conjunto de tecnologias baseadas na integração de recursos de consulta
    diretamente na linguagem C#
        - permite escrever consultas fortemente tipadas
        - fornece sintaxe baseada em SQL e uma experiência de consulta consistente
          para objetos e diversas fontes de dados
        - para usar, é necessário importatar o namespace System.Linq
 
    recursos que dão suporte a LINQ:
        - expressões de consulta 
            usa sintaxe declarativa semelhante ao SQL para consultar em coleções IEnumerable
        - métodos de extensão 
            os operadores de consulta padrão são um conjunto de métodos de extensão que
            fornecem a funcionalidade de consulta para qualquer tipo que implementa IEnumerable<T>/IQueryable<T>
        - expressões lambda
            são usadas para fazer chamadas de método diretas nos operadores de consulta padrão
        - tipos anônimos
            permitem criar objetos que contêm um conjunto de propriedades, sem a necessidade
            de definir uma classe explicitamente, simplificando o código
        - variáveis tipadas implicitamente
            usa var para instruir o compilador a inferir e atribuir o tipo
        - inicializadores de objeto e coleção
            permite inicializar objetos sem chamar explicitamente um construtor para o objeto, 
            são usados em expressões de consulta quando projetam os dados de origem em um novo
            tipo de dados
 
 */

/*
 
    sintaxe de consulta (query syntax, query expression syntax):
        é escrita usando uma sintaxe semelhante ao SQL, usando select, from, where, group by, order bt, etc

        FROM object in DataSource
        WHERE condition
        SELECT object
 
 */

List<string> nomes = new List<string>() 
{
    "ana", "maria", "joão", "josé"
};

Console.WriteLine("\nlista de nomes:");
foreach (var n in nomes)
    Console.Write(n + "   ");
Console.WriteLine();

Console.WriteLine("\nusando LINQ com sintaxe de consulta\n");
var resultado1 = from n in nomes 
                where n.Contains('o') 
                select n;

foreach (var r in resultado1)
    Console.WriteLine($"resultado da consulta: {r}");

/*
 
    sintaxe de método (method syntax, fluent syntax):
        é escrita usando métodos de extensão definidos nas interfaces IEnumerable e IQueryable
 
 */

Console.WriteLine("\nusando LINQ com sintaxe de método\n");
var resultado2 = nomes.Where(n => n.Contains('a'));

foreach(var r in resultado2)
    Console.WriteLine($"resultado da consulta: {r}");
