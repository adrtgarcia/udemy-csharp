Console.WriteLine("--- Exemplo Prático de Ranges e Indices ---");

string[] logEntries = new string[]
{
   "2023-10-26 10:00:01 INFO: Aplicativo iniciado com sucesso.",
   "2023-10-26 10:00:05 WARN: Conexão com o banco de dados lenta.",
   "2023-10-26 10:00:10 ERROR: Falha ao processar a requisição do usuário 'joao'.",
   "2023-10-26 10:00:15 INFO: Nova sessão de usuário 'maria' iniciada.",
   "2023-10-26 10:00:20 WARN: Cache de dados expirado, recarregando.",
   "2023-10-26 10:00:25 ERROR: Credenciais inválidas para o serviço X.",
   "2023-10-26 10:00:30 INFO: Tarefa agendada concluída."
 };

Console.WriteLine("\nExibindo o array de strings : logEntries[]");
foreach (string logEntry in logEntries)
    Console.WriteLine(logEntry);

// Pegando o último registro do log:
Console.WriteLine("\nPegando o último registro do log: logEntries[^1]");
string ultimoRegistro = logEntries[^1];
Console.WriteLine($"- {ultimoRegistro}");

//pegar os 3 últimos registro do log
Console.WriteLine("\nOs 3 últimos registros do log: logEntries[^3..]");
foreach (var entry in logEntries[^3..])
    Console.WriteLine($"- {entry}");

// Extrair a data (primeiros 19 caracteres) do 4º registro do log
Console.WriteLine("\nExtraindo a data do 4o elemento do array : logEntries[3][..19]");
string dataQuartoLog = logEntries[3][..19];
Console.WriteLine($"- {dataQuartoLog}"); // Saída: "2023-10-26 10:00:15"

Console.ReadKey();
