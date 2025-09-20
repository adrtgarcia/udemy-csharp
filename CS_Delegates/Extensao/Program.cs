Console.WriteLine("Métodos de Extensão");

/*
 
    MÉTODOS DE EXTENSÃO permitem estender a funcionalidade de um tipo existente sem criar
    um novo tipo derivado, recompilar ou modificar o tipo original
        - são um tipo especial de método estático chamado como se fosse um método de instância
          no tipo estendido
        - úteis para estender a funcionalidade de tipos existentes, como as classes da biblioteca
          padrão ou classe definidas por outras bibliotecas de terceiros
 
    criação de um método de extensão:
        1) crie uma classe estática para conter o método de extensão, a classe deve estar visível 
           para o código cliente
        2) implemente o método de extensão como um método estático com pelo menos a mesma visibilidade
           da classe que o contém
        3) o primeiro parâmetro do método especifica o tipo no qual o método opera, ele deve ser
           precidido pelo modificador THIS
        4) no código de chamada, adicione uma diretiva USING para especificar o NAMESPACE que contém
           a classe do método de extensão
        5) chame os métodos como se fossem métodos de instância no tipo

 */

string curso = "curso-c#-essencial";
string cursoInvertido = curso.InverteString();

Console.WriteLine($"string original: {curso}");
Console.WriteLine($"string invertida: {cursoInvertido}");

public static class StringExtensions
{
    public static string InverteString(this string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
