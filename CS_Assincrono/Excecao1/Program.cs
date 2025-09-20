Console.WriteLine("Tratamento de Exceções");

/*
 
    programação síncrona:
        o código que lança uma exceção se propaga para cima na pilha de chamadas
        até que a pilha de chamadas encontre um bloco catch para fazer o tratamento

    programação assíncrona:
        quando o código executado lança uma exceção, ela é armazenada no objeto Task (Faulted),
        que contém a propriedade Task.Exception
            - Tasks no estado Faulted vão lançar uma exceção quando forem aguardadas (await)

        as exceções lançadas com tipos de retorno Task ou Task<T> são encapsuladas em
        uma instância da classe AggregateException e associadas à instância Task

        se mais de uma exceção for lançada, todas elas serão armazenadas na coleção
        AggregateException.InnerExceptions

        os métodos assíncronos com um tipo de retorno void não possuem um objeto Task
        associados a eles, e assim as exceções lançadas em um método async void não
        podem ser capturadas fora desse método
            - o bloco try-catch deve ser definido dentro do método  

 */

TesteAsync t = new();
t.ChamaTarefaAsync();

/* try { t.ChamaTarefaAsync(); }
   catch (Exception e) { Console.WriteLine(e.Message); }  <- não funciona */

public class TesteAsync
{
    public Task MinhaTarefaAsync()
    {
        return Task.Run(() =>
        {
            Task.Delay(2000);
            throw new Exception("erro MinhaTarefaAsync");
        });
    }
    public async void ChamaTarefaAsync()
    {
        try
        {
            await MinhaTarefaAsync();
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message); /* agora o tratamento será possível */
        }
    }
}
