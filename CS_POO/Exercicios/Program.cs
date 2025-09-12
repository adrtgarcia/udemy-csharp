Console.WriteLine("Exercícios - POO");

/*
 
 EX01
    Uma classe derivada pode interromper a herança virtual declarando
    um override como SEALED
 
 */


/*
 
 EX02
    NEW é usada para alterar os dados e o comportamento de uma classe base
    substituindo um membro de uma classe base por um novo membro derivado
 
 */


/*
 
 EX03
    Ao substituir um método virtual, os nomes e as assinaturas do método de
    substituição devem ser os mesmos do método virtual que está sendo substituído
 
 */


// EX04
B b = new();
b.i = 1;
b.j = 2;
b.Exibir();     /* b armazena i, j, mas imprime apenas j = 2 */


// EX05
C c = new();
D d = new();
C x = c;
x.Exibir();     /* x imprime "C" */
x = d;
x.Exibir();     /* x imprime "D" */


/*
 
 EX06
    São requisitos necessários para o polimorfismo em tempo de execução:
        - o método base substituído deve ser virtual ou abstract
        - tanto o método override quanto o método virtual devem ter o mesmo modificador de nível de acesso
        - um método abstrato é implicitamente um método virtual
 */


// EX07
Carro carro = new(0);
Console.WriteLine("\ndigite quanto de gasolina para abastecer:");
int qntGasolina = Convert.ToInt32(Console.ReadLine());
if (carro.Abastecer(qntGasolina)) { carro.Dirigir(); }


// EX08
LivroFotos album1 = new();
Console.WriteLine($"\nálbum padrão: {album1.GetNumeroPaginas()} páginas");
LivroFotos album2 = new(24);
Console.WriteLine($"álbum personalizado: {album2.GetNumeroPaginas()} páginas");
SuperLivroFotos album3 = new();
Console.WriteLine($"álbum grande:: {album3.GetNumeroPaginas()} páginas");


// EX09
Pessoa[] p1 = new Pessoa[3];
Console.WriteLine("\ninforme o nome do aluno:");
p1[0] = new Aluno(Console.ReadLine());
Console.WriteLine("informe o nome do aluno:");
p1[1] = new Aluno(Console.ReadLine());
Console.WriteLine("informe o nome do professor:");
p1[2] = new Professor(Console.ReadLine());
((Professor)p1[2]).Explicar();
((Aluno)p1[1]).Estudar();
((Aluno)p1[0]).Estudar();


// EX10
Pessoa[] p2 = new Pessoa[3];
Console.WriteLine("\ninforme o nome da pessoa:");
p2[0] = new Pessoa(Console.ReadLine());
Console.WriteLine("informe o nome da pessoa:");
p2[1] = new Pessoa(Console.ReadLine());
Console.WriteLine("informe o nome da pessoa:");
p2[2] = new Pessoa(Console.ReadLine());
foreach (Pessoa p in p2) { Console.WriteLine(p.ToString()); }


/*
 
 EX11
    Para chamar o método Conectar() da classe SQLServer sem alterar o código na Main, como método Conectar() da classe
    abstrata é virtual, ele pode ser sobrescrito na classe derivada, utlizando public override void Conectar()
 
 */
Database db = new SQLServer();
db.Configurar();
db.Conectar();


/*
 
 EX12
    A variável da classe base texto está sendo inicializada por meio do construtor da classe derivada usando a
    palavra-chave base
        - Assim, o construtor da classe base vai atribuir o valor de str à variável texto
    Portanto, na criaçaõ do objeto, a string informada está disponível tanto para a classe base quanto para o corpo do
    construtor da classe derivada
        - Resultado: terá a exibição no console do texto 'Olá mundo...'
 
 */
Y y = new("Olá mundo...");
y.Exibir();


/*
 
 EX13
    Como a classe Exibir está implementando as duas interfaces e ambas possuem a definição de um método com o mesmo nome,
    teremos ambiguidade sobre qual dos métodos invocar na classe
        - Se as duas interfaces tiverem o mesmo contrato, a implementação da classe precisa de um identificador de interface,
          e isso é feito realizando a implementação explícita de interface (InterfaceNome.MetodoNome())
 
 */


/*
 
 EX14
    Na linguagem C# não podemos criar um objeto da classe derivada a partir da sua classe base. Quando criamos um objeto de uma classe,
    sua referência é armazenada na memória stack, o objeto é armazenado na memória heap e o endereço do objeto é atribuído à referência da classe

    Dado o código:
        Filha ofilha = new Filha();
    
    1) Filha é a classe
    2) ofilha é o objeto da classe, sendo uma referência à classe Filha criada na memória stack
    3) new Filha() vai criar o objeto do tipo Filha na memória heap e o endereço dele é atribuído à referência do objeto

    Ao tentar criar um objeto da classe derivada a partir da classe base, teremos uma chamada cíclica entre o construtor da
    classe-filha e da classe-mãe, causando um estouro na pilha (memória stack)
        - StackOverflowException é lancaçada
 
 */


/*
 
 EX15
    A classe MastroCreditCard precisa implementar a validação do cartão e a inicialização da transação, que devem
    ser definidos em classes ou interfaces diferentes, e com isso vai precisar herdar das duas classes/interfaces

    Como não podemos herdar de duas classes, a soluçãi é criar duas interfaces (ou uma classe e uma interface) e fazer
    com que a classe MastroCreditCard herde das duas interfaces (ou herda da classe e implemente a interface)
 
 */
MastroCreditCard cartao = new();
cartao.ValidarCartao();
cartao.IniciarTransacao();
cartao.StatusTransacao();


// EX16
var formas = new List<Forma>()
{
    new Quadrado(9),
    new Triangulo(3, 4),
    new Circulo(5)
};
foreach (Forma f in formas) Console.WriteLine($"\nárea: {f.CalcularArea()}");
