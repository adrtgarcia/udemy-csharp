Console.WriteLine("Estruturas GOTO e LABEL");

/*

GOTO transfere o controle de uma parte para outra do programa com a ajuda de um identificador LABEL

sintaxe:
    label: 
        // código a ser executado
    condição
        goto label

ou ainda:
    condição
        goto label
    label:
        // código a ser executado

*/

Console.WriteLine("\ninício do processamento...");
int i = 1;

repetir:
    Console.WriteLine($"i = {i}");
    i++;
    if (i <= 10) 
        goto repetir;

Console.WriteLine("fim do processamento");

