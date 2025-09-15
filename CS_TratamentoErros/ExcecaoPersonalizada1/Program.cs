Console.WriteLine("Exceções Personalizadas");

/*
 
    é possível criar uma classe personalizada devirando de System.Exception
        - finalizar o nome da nova exceção com Exception
        - implementar os três construtores comuns

    implementação:
        (1) crie uma classe de exceção separada para cada condição de erro que deseja manipular, isso torna mais fácil identificar
            e lidar com exceções específicas
        (2) substitua a propriedade Message para fornecer uma mensagem de erro significativa que descreva a condição de erro, essa
            mensagem será exibida quando a exceção for lançada
        (3) substitua o método ToString() para retornar uma representação de string da exceção, que pode ser útil para fins de log
            e depuração
        (4) adicione propriedades ou métodos adicionais necessários à classe de exceção personalizada para fornecer mais informações
            sobre a condição do erro
         
 */

try
{
    throw new ExemploException("testando exceção criada");
}
catch (ExemploException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}

public class ExemploException : Exception
{
    public ExemploException() { }
    public ExemploException(string message) : base(message) { }
    public ExemploException(string message, Exception inner) : base(message, inner) { }
}
