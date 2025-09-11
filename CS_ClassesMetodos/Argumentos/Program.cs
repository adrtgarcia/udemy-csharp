/*

    PASSAGEM DE ARGUMENTO POR VALOR (PADRÃO): 
    é feita uma cópia do valor do argumento, que é passada para o parâmetro do método chamado
        - as alterações na cópia não afetam o valor da variável original no chamador

    PASSAGEM DE ARGUMENTO POR REFERÊNCIA (REF E OUT):
    passa a referência ao mesmo local de memória dos argumentos para os parâmetros, nenhuma cópia é passada
        - o chamador dá ao método a capacidade de acessar e modificar a variável original do chamador
        - ou seja, passamos o acesso à variável para o método

 */

Console.WriteLine("Passando argumentos por valor");

int x = 20;
Console.WriteLine($"x = {x} \t<- antes de ser passado por valor");

Calculadora calc = new();
calc.DobrarNumero(x);

Console.WriteLine($"x = {x} \t<- depois de ser passado por valor\n");


Console.WriteLine("\n\nPassando argumentos por referência (REF)");

int y = 30;
Console.WriteLine($"\ny = {y} \t<- antes de ser passado por ref");
calc.DobrarNumero(ref y);
Console.WriteLine($"y = {y} \t<- depois de ser passado por ref");


Console.WriteLine("\n\nPassando argumentos por referência (OUT)");

Circulo circ = new();

double area = circ.CalcularArea(5);
double perimetro = circ.CalcularPerimetro(5);
Console.WriteLine($"Círculo de raio 5: área = {area}, perímetro = {perimetro}");

circ.CalcularAmbos(5, out area, out perimetro); // se area e perimetro não estivessem definidos, seria necessário definir na passagem de parâmetro
Console.WriteLine($"Círculo de raio 5: área = {area}, perímetro = {perimetro}");


Console.WriteLine("\n\nArgumentos nomeados");
Email em = new();
em.Enviar("teste@email.com", "Urgente", "Reunião de orçamento");
em.Enviar(titulo: "Urgente", assunto: "Reunião de orçamento", destino: "teste@email.com");

Console.WriteLine("\n\nParâmetros opcionais");
em.EnviarEmail("teste@email.com");
em.EnviarEmail("teste@email.com", "Urgente", "Reunião de orçamento");
em.EnviarEmail("teste@email.com", assunto: "Reunião de orçamento");

public class Calculadora
{
    public void DobrarNumero(int numero)
    {
        Console.WriteLine($"x = {numero} \t<- início da execução do método");
        numero *= 2;
        Console.WriteLine($"x = {numero} \t<- fim da execução do método");
    }

    public void DobrarNumero(ref int numero)
    {
        Console.WriteLine($"y = {numero} \t<- início da execução do método");
        numero *= 2;
        Console.WriteLine($"y = {numero} \t<- fim da execução do método");
    }
}

public class Circulo
{
    public double CalcularArea(double raio)
    {
        double area = Math.PI * Math.Pow(raio, 2);
        return area;
    }

    public double CalcularPerimetro(double raio)
    {
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }

    public void CalcularAmbos(double raio, out double area, out double perimetro)
    {
        area = Math.PI * Math.Pow(raio, 2);
        perimetro = 2 * Math.PI * raio;
    }

    /*
    public double CalcularAmbos(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
    */
}

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino}, {titulo} - {assunto}");
    }

    public void EnviarEmail(string destino, string titulo = "Reunião", string assunto = "Avaliação mensal")
    {
        Console.WriteLine($"\nPara {destino}, {titulo} - {assunto}");
    }
}