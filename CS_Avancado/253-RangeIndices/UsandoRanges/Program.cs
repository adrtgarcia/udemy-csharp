Console.WriteLine("Usando Ranges\n");

                        // Exemplo com Ranges:
                        // 0       1     2      3       4     5      6
string[] diasDaSemana = { "Seg", "Ter", "Qua", "Qui", "Sex", "Sab", "Dom" };

// Pegando os dias úteis (índice 0 até 5, exclusivo no final):
string[] diasUteis = diasDaSemana[0..5]; // {"Seg", "Ter", "Qua", "Qui", "Sex"}
Console.WriteLine(string.Join(", ", diasUteis));

// Pegando do terceiro dia até o final:
string[] doMeioAoFim = diasDaSemana[2..]; // {"Qua", "Qui", "Sex", "Sab", "Dom"}
Console.WriteLine(string.Join(", ", doMeioAoFim));

// Pegando do começo até o penúltimo:
string[] doComecoAtePenultimo = diasDaSemana[..^1]; // {"Seg", "Ter", "Qua", "Qui", "Sex", "Sab"}
Console.WriteLine(string.Join(", ", doComecoAtePenultimo));

// Copiando o array inteiro 
string[] copiaCompleta = diasDaSemana[..]; // {"Seg", "Ter", "Qua", "Qui", "Sex", "Sab", "Dom"}
Console.WriteLine(string.Join(", ", copiaCompleta));

Console.ReadKey();
