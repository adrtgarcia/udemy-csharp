Console.WriteLine("Funções anônimas - Expressão Lambda");

/*
 
    uma função anônima não possui nome, ela pode ser definida usando delegate e pode
    ser atribuída a uma variável delegate
        - ou seja, é uma declaração in-line ou expressão que pode ser usada sempre que
          um tipo delegate for esperado
        - podemos usá-la para inicializar um delegate nomeado ou passar um método anônimo
          em vez de um tipo de delegate nomeado como um parâmetro de método

*/

/* Expressões Lambdas (Lambdas Expressions) */

List<string> nomes = new()
{
    "maria", "joão", "josé", "ana"
};

string resultado = nomes.Find(nome => nome.Equals("ana"));

Console.WriteLine(resultado);


/* versão método anônimo:

string resultado = nomes.Find(delegate (string nome)
{
    Console.WriteLine($"verificando lista: {nome}");
    return nome.Equals("ana");
});
 */


/* versão tradicional:

static bool VerificaNomeLista(string nome)
{
    Console.WriteLine($"verificando lista: {nome}");
    return nome.Equals("ana");
}
 */
