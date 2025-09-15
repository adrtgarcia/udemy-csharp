Console.WriteLine("Exercício - Filtrando Exceções");

/*
 
    código de status http e suas mensagens
        200 - ok: a solicitação foi bem-sucedida e o servidor retornou o conteúdo solicitado
        400 - bad request: a solicitação é inválida e não pode ser processada pelo servidor
        401 - unauthorize: o cliente não está autorizado a acessar o recurso solicitado
        403 - forbidden: o cliente está probido de acessar o recurso solicitado
        404 - not found: o recurso solicitado não foi encontrado no servidor
        500 - internal server error: ocorreu erro no servidor durante o processamento da solicitação
 
    http://developer.mozilla.org/en-US/docs/Web/HTTP/Status

 */

try
{
    Console.WriteLine("\nacessando o arquivo poesia.txt em https://macoratti.net");
    Console.WriteLine("\naguarde...");

    string? arquivo = "poesia.txt";
    string? url = "https://macoratti.net/dados/";

    HttpClient hp = new();
    HttpResponseMessage response = hp.GetAsync(url + arquivo).Result;

    if(response.IsSuccessStatusCode)
    {
        Console.WriteLine("\nacesso ao arquivo feito com sucesso");
        Console.WriteLine($"\ncódigo de status: {response.StatusCode}");
    }
    else
    {
        throw new HttpRequestException($"erro: {(int)response.StatusCode}");
    }
}
catch (HttpRequestException e) when (e.Message.Contains("400"))
{
    Console.WriteLine("\nrequisição inválida");
}
catch (HttpRequestException e) when (e.Message.Contains("401"))
{
    Console.WriteLine("\nacesso não autorizado");
}
catch (HttpRequestException e) when (e.Message.Contains("404"))
{
    Console.WriteLine("\npágina não encontrada");
}
catch (HttpRequestException e) when (e.Message.Contains("500"))
{
    Console.WriteLine("\nerro interno do servidor");
}
catch (Exception e)
{
    Console.WriteLine("\n" + e.Message);
    Console.WriteLine("\n" + e.StackTrace);
}
finally
{
    Console.WriteLine("\nprocessamento concluído");
}
