using System.Threading.Channels;

Console.WriteLine("Interfaces");

/*
 
    interfaces podem conter as assinaturas de métodos, eventos, propriedades e indexadores,
    também podem conter métodos públicos e estáticos que contém uma implementação
    
    regra geral:
        - não pode ser instanciada diretamente e seus membros abstratos são implementados
          por qualquer classe/struct que implemente a interface
        - funciona como um contrato, a classe que implementa uma interface é obrigada a implementar
          todos os seus membros abstratos
        - uma classe pode herdar 1 classe base e N interfaces
        - se uma classe mãe implementar uma interface, suas filhas herdam a implementação

    sintaxe:
        interface INome { ... }
            - boa prática: adicionar "i" ao nome da interface
 
 */

Demo d = new();
d.Desenhar();
// d.Colorir();
d.Pintar();
Console.WriteLine();

IDesenho id = new Demo();
id.Desenhar();
id.Colorir();
// id.Pintar();
Console.WriteLine();

IPintura ip = new Demo();
// ip.Desenhar();
// ip.Colorir();
ip.Pintar();
Console.WriteLine();

interface IDesenho { public void Desenhar(); public void Colorir() { Console.WriteLine("colorindo..."); } }
interface IPintura { public void Pintar(); }

public class Demo : IDesenho, IPintura
{
    public void Desenhar() => Console.WriteLine("desenhando...");
    public void Pintar() => Console.WriteLine("pintando...");
}