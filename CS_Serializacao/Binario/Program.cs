using System.Runtime.Serialization.Formatters.Binary;

namespace Binario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serialização Binária");

            /*
 
            Serialização é o processo de conversão do estado de um objeto em um formato que possa ser
            armazenado e/ou transportado
                - em outras palavras: é o processo de conversão de um objeto em um fluxo de bytes (stream) de forma que possa
                  ser armazenado na memória, em arquivo ou em um banco de dados
    
            Desserialização é o complemento da serialização, que converte um fluxo de bytes (stream)
            em um objeto   
  
            */

            /*

            serialização binária (obsoleta):
                 - preserva a fidelidade do tipo
                 - preserva o estado de um objeto

             */

            Aluno a = new(101, "Maria", "maria@email.com", 17);
            var caminho = @"C:\Users\amand\OneDrive\Área de Trabalho\temp\binario.txt";

            using (FileStream fs = new(caminho, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(fs, a);
            }

            Console.WriteLine("Serialização concluída");

            using (FileStream fs = new(caminho, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                var bf = new BinaryFormatter();
                var aluno = (Aluno)bf.Deserialize(fs);
            }

            Console.WriteLine("Desserialização concluída");

        }
    }
}
