Console.WriteLine("Propriedades");

/*
 
 uma propriedade é um membro da classe que fornece um mecanismo de ler, gravar ou calcular o calor de um campo privado,
 permitindo que uma classe exponha de maneira pública de obter e definir valor, enquanto oculta o código de implementação ou verificação
    - somente leitura: possui apenas get
    - somente gravação: possui apenas set
 */

public class Pessoa
{
    public string Nome { get; set; }
    public int Conta { get; }
    // public int senha { set; }
    
    /*
    private string nome;            <- campo
    public string Nome              <- propriedade
    {
        get { return nome; }
        set { nome = value; }
    }
    */

}