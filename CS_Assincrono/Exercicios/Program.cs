Console.WriteLine("Exercícios");

/*
 
    EX01
        A programação assíncrona é uma técnica de programação que permite que um aplicativo execute operações em
        segundo plano sem bloquear a thread principal, permitindo que a interface do usuário continue respondendo
        enquanto as operações estão em andamento. Isso é importante porque operações que consomem muitos recursos,
        como E/S de disco ou rede, podem levar muito tempo para serem concluídas, e bloquear a thread principal pode
        tornar o aplicativo não responsivo.


    EX02
        No C#, a programação assíncrona é implementada usando as classes Task e Task<T>. A classe Task representa uma
        operação assíncrona que não retorna um valor, enquanto a classe Task<T> representa uma operação assíncrona que
        retorna um valor do tipo T.

        Ambas as classes usam o modelo de programação baseado em Promises, onde uma operação assíncrona retorna
        uma Task ou Task<T> imediatamente e é concluída posteriormente em segundo plano.


    EX03
        A palavra-chave ASYNC é usada para marcar um método como assíncrono em C#. Isso permite que o método use a
        palavra-chave AWAIT para aguardar a conclusão de operações assíncronas sem bloquear a thread principal. 

            public async Task<string> DownloadAsync(string url)
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    var content = await response.Content.ReadAsStringAsync();
                    return content;
                }
            }

        Neste exemplo, o método "DownloadAsync" é marcado como assíncrono com a palavra-chave "async". Ele usa a
        classe HttpClient para fazer uma solicitação HTTP assíncrona para a URL fornecida e, em seguida, aguarda a
        conclusão da solicitação usando a palavra-chave "await".


    EX04
        No modelo de programação síncrona, uma operação é executada de forma sequencial, bloqueando a thread principal
        até que a operação seja concluída. Isso pode tornar o aplicativo não responsivo se a operação levar muito tempo
        para ser concluída. No modelo de programação assíncrona, a operação é executada em segundo plano, permitindo
        que a thread principal continue respondendo a eventos do usuário e executar outras operações enquanto a operação
        assíncrona está em andamento. Isso torna o aplicativo mais responsivo e melhora a experiência do usuário.


    EX05
        Em C#, a classe Task e a classe ValueTask são usadas para representar uma operação assíncrona que pode ser
        executada de forma assíncrona. Ambas as classes têm recursos semelhantes, como suporte a cancelamento,
        progresso e continuação.

        A principal diferença é que Task é uma classe de referência, enquanto ValueTask é uma estrutura. Isso 
        significa que ValueTask é geralmente mais eficiente em termos de memória e desempenho do que Task, 
        especialmente em cenários em que a operação assíncrona é concluída de forma síncrona ou rapidamente.
        
        Outra diferença importante é que ValueTask é mais adequado para operações assíncronas que retornam um
        resultado. Nesses casos, ValueTask pode encapsular um valor de resultado diretamente, enquanto Task requer uma
        tarefa secundária para envolver o valor de resultado.

        Em geral, é preferível usar ValueTask em cenários em que a operação assíncrona é concluída de forma
        síncrona ou rapidamente, ou quando se está trabalhando com resultados de operações assíncronas. Por outro
        lado, Task é mais adequado para operações assíncronas mais longas e complexas, onde a eficiência de memória é
        menos crítica.


    EX06
        - Use ValueTask sempre que possível, especialmente se a operação assíncrona é concluída de forma síncrona 
          ou rapidamente.
        - Use construtores apropriados para criar uma instância de ValueTask com ou sem um resultado. 
        - Use async ValueTask como tipo de retorno para métodos assíncronos que podem retornar uma instância de 
          ValueTask. 


    EX07
        Em C#, ao lidar com exceções em operações assíncronas, é importante lembrar que as exceções podem ser lançadas
        em qualquer momento, incluindo durante a execução de tarefas assíncronas. Para lidar com essas exceções, é
        recomendável usar o bloco try/catch, assim como se faria com código síncrono.

        No entanto, como as tarefas assíncronas são executadas em segundo plano, é possível que uma exceção seja lançada
        em uma thread diferente da thread principal. Nesse caso, a exceção pode não ser capturada pelo bloco try/catch da
        thread principal. Para resolver esse problema, é possível usar o método Wait() para esperar que a tarefa assíncrona
        seja concluída e, em seguida, capturar a exceção.

        Outra opção é usar o bloco try/catch dentro da própria tarefa assíncrona para capturar exceções específicas e
        tratálas de maneira apropriada. Além disso, é importante lembrar que as exceções assíncronas podem ser 
        propagadas de volta ao chamador, então é fundamental ter um tratamento adequado de exceções em todos os pontos 
        da cadeia de chamada.
        
        Algumas das melhores práticas para lidar com exceções em código assíncrono incluem:
        - Usar o bloco try/catch para capturar exceções, como faria com código síncrono.
        - Usar o bloco try/catch dentro da própria tarefa assíncrona para capturar exceções específicas e tratá-las de
          maneira apropriada.
        - Certificar-se de que todas as exceções são tratadas em todos os pontos da cadeia de chamada.
        - Evitar a captura de exceções genéricas, como Exception, e capturar exceções mais específicas sempre que
          possível.
        - Registrar exceções em logs para ajudar na depuração e resolução de problemas.


    EX08


    EX09
        As melhores práticas para o cancelamento de tarefas assíncronas em C# incluem:
        - Use CancellationTokenSource e CancellationToken para cancelar a tarefa, pois o CancellationToken permite 
          que a tarefa verifique se foi cancelada, enquanto o CancellationTokenSource permite que você cancele a 
          tarefa de fora da tarefa.
        - Verifique regularmente o CancellationToken dentro da tarefa, pois se o token tiver sido acionado, a tarefa
          deve ser cancelada.
        - Use operações de E/S assíncronas com CancellationToken para permitir o cancelamento imediato.
        - Limpe recursos alocados para evitar vazamentos de memória. Isso pode incluir fechar arquivos, conexões de rede, 
          ou liberar memória alocada para a tarefa.
        - Reverta as alterações feitas antes do cancelamento, para garantir que o estado compartilhado permaneça
          consistente.
        - Considere usar transações para operações atômicas, para garantir que as operações sejam completamente 
          revertidas se a tarefa for cancelada.


    EX10
        - Crie um objeto CancellationTokenSource que possa ser usado para cancelar a operação assíncrona.    
        - Crie uma tarefa assíncrona que pode ser cancelada usando o token de cancelamento. A tarefa pode lançar exceções
          em casos de erro.
        - Chame a tarefa assíncrona usando o token de cancelamento e capture quaisquer exceções lançadas. 


    EX11
        A classe CancellationToken e a exceção OperationCanceledException são duas formas de implementar o
        cancelamento de exceções em operações assíncronas em C# e a principal diferença entre elas é que a classe 
        CancellationToken permite cancelar a operação de forma assíncrona, enquanto a exceção OperationCanceledException 
        é utilizada para notificar que a operação foi cancelada.
        
        O uso da classe CancellationToken é mais recomendado em operações que podem levar um tempo maior para serem
        concluídas, pois permite que a operação seja interrompida de forma assíncrona em vez de esperar até que a
        operação conclua sua execução.
        
        Por outro lado, a exceção OperationCanceledException é mais recomendada para operações mais simples que não
        necessitam de um mecanismo de cancelamento assíncrono.
  
 */
