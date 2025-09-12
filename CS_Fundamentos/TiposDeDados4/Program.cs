Console.WriteLine("hello world");

/*
 
ATALHOS:
ctrl + f5 >> executa o código sem depuração
f5 >> executa o código com depuração
ctrl + k + d >> organiza o código
ctrl + d >> duplica a linha onde o cursor está
ctrl + f >> localiza algo no documento atual

*/

Console.WriteLine("Tipos de referência pré-definidos: String, Object, Dynamic");

string nome = "Curso C#";       
String titulo = "C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

nome = "Isso é uma string";     
Console.WriteLine(nome);

/*
 
Strings são imutáveis, então uma vez declarada, se for modificada, todos os seus valores estarão 
armazenados na memória.
* o garbage colector lidará com isso depois
* solução: StringBuilder

*/

object numero = 123;
object endereco = "Rua ABC, 123";
object letra = 'a';
object preco = 15.99;

Console.WriteLine(numero);
Console.WriteLine(endereco);
Console.WriteLine(letra);
Console.WriteLine(preco);

/*
 
Object é uma variável curinga, e pode assumir qualquer tipo de dado, pois é a base de todos
*`útil para quando não se sabe qual valor uma dada variável irá receber 

Dynamic tem comportamento parecido com Object
* útil quando se quer usar recursos mais avançados (ex: linguagens dinâmicas)

*/

dynamic numero1 = 123;
dynamic endereco1 = "Rua ABC, 123";
dynamic letra1 = 'a';
dynamic preco1 = 15.99;

Console.WriteLine(numero1);
Console.WriteLine(endereco1);
Console.WriteLine(letra1);
Console.WriteLine(preco1);

numero = 'a';
Console.WriteLine(numero);
numero1 = "rua abc";
Console.WriteLine(numero1);

/*
 
TIPOS DE REFERÊNCIA (memória heap) -> string, class, object, dynamic 
não armazenam dados diretamente, cada tem uma referência ao local da memória onde os dados estão armazenados

TIPOS DE VALOR (memória stack) -> tipos de dados numéricos e não numéricos
armazenam diretamente seus dados e cada variável tem uma cópia dos dados

*/
