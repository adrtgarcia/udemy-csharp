Console.WriteLine("Exercício - Programação Assíncrona");
await OperarAsync();

static async Task OperarAsync()
{
    var tempo = 10;
    var cToken = new CancellationTokenSource(TimeSpan.FromSeconds(tempo));

    Console.WriteLine("\nIniciando download...");
    Console.WriteLine($"\nCancelando após {tempo}s");

	try
	{
		using var hClient = new HttpClient();
		var destino = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\async.txt";

		var response = await hClient.GetAsync("https://www.macoratti.net/dados/Poesia.txt", HttpCompletionOption.ResponseHeadersRead, cToken.Token);

		var totalBytes = response.Content.Headers.ContentLength;
		var readBytes = 0L;

		await using var fs = new FileStream(destino, FileMode.Create, FileAccess.Write);

		await using var contentStream = await response.Content.ReadAsStreamAsync(cToken.Token);

		var buffer = new byte[81920];
		int bytesRead;

		while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length, cToken.Token)) > 0)
		{
			await fs.WriteAsync(buffer, 0, bytesRead, cToken.Token);
			readBytes += bytesRead;
			Console.WriteLine($"Progresso: {readBytes}/{totalBytes} ({(readBytes / totalBytes) * 100}%)");
		}

	}
	catch (OperationCanceledException e)
	{
		if (cToken.IsCancellationRequested)
			Console.WriteLine("\nDownload cancelado pelo usuário");
		else
			Console.WriteLine("\nDownload atingiu tempo limite");
        Console.WriteLine(e.Message);
    }
	catch (HttpRequestException e)
	{
        Console.WriteLine("\nOcorreu um erro de rede");
        Console.WriteLine(e.Message);
	}
	catch (Exception e)
	{
        Console.WriteLine("\nOcorreu um erro desconhecido");
        Console.WriteLine(e.Message);
	}
	finally
	{
		Console.WriteLine("\nFim da execução");
	}
}
