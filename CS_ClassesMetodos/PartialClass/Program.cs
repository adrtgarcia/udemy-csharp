using PartialClass;
using System.Diagnostics;

Console.WriteLine("Partial Class");

/*
 
    PARTIAL CLASS:  
        forma de dividir a definição de uma classe em múltiplos arquivos, mas que são tratados
        como uma única classe pelo compilador
            - é possível definir classes, interfaces, structs e métodos parciais 

    REGRAS:
        1) todas as definições devem estar no mesmo assembly e namespace
        2) todas as partes devem possuir a mesma acessibilidade
        3) se qualquer parte for abstract, todas devem ser
        4) "partial" só deve vir antes das palavras-chave class, struct ou interface
        5) tipos parciais aninhados são permitidos
        6) atributos se aplicam a todas as partes da classe
        7) características definidas em qualquer parte estão disponíveis para todas

 */

MinhaPartialClass mpc = new();
mpc.Nome = "maria";
mpc.DataNascimento = new DateTime(2004, 09, 23);

Console.WriteLine($"Calculando idade: {Math.Round(mpc.CalculaIdade(mpc.DataNascimento).TotalDays/365)}");

DateTime data1 = new(2025, 09, 05);
DateTime data2 = new(2025, 12, 25);

Console.WriteLine($"Diferença de dias entre {data1} e {data2}: {mpc.DiferencaEntreDatas(data2, data1)}");