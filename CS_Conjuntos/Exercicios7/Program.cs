using System.Runtime.CompilerServices;

Console.WriteLine("Exercício 07");

Aluno alunos = new Aluno();
alunos[0] = "maria";
alunos[1] = "joão";
alunos[2] = "josé";
alunos[15] = "ana";

Console.WriteLine($"\nalunos[0] = {alunos[0]}");
Console.WriteLine($"alunos[1] = {alunos[1]}");
Console.WriteLine($"alunos[2] = {alunos[2]}");
Console.WriteLine($"alunos[15] = {alunos[15]}");

public class Aluno
{
    string[] nome = new string[10];
    public string this[int i]
    {
        get 
        {
            if (i >= 0 && i <= nome.Length)
                return nome[i];
            return "Erro";
        }
        set 
        {
            if (i >= 0 && i <= nome.Length) 
                nome[i] = value;
        }
    }
}