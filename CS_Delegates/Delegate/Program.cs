using Delegate;

Console.WriteLine("Delegates");

/*
 
    DELEGATE é um tipo que representa referências a métodos com uma lista de parâmetros e um
    tipo de retorno específicos
        - a instância de um Delegate pode ser associada a qualquer método com uma assinatura
          compatível e tipo de retorno, sendo possível invocar o método por meio da instância
          delegada
        - é usado para implementar eventos, métodos de retorno de chamada e para passar métodos
          como argumentos para outros métodos
        - permite maior flexibilidade para implementar qualquer funcionalidade em tempo de execução
 
    um delegate é um tipo de dados (tipo de referência) que define a assinatura de um método,
    que permite definir variáveis que podem se referir a qualquer método que tiver a mesma
    assinatura do delegate

    etapas:
        (1) declarar um delegate
        (2) definir um método de destino
        (3) invocar ou chamar um delegate

    sintaxe:
        <modificador de acesso> delegate <tipo de retorno> NomeDelegate(<parâmetros>)

 */


MeuDelegate del = MeuMetodo;
del.Invoke("teste 1");
del("teste 2");

DelegateCalculadora calc = Calculadora.Somar;
Console.WriteLine($"DelegateCalculadora -> Somar: {calc.Invoke(9, 1)}");

calc = Calculadora.Subtrair;
Console.WriteLine($"DelegateCalculadora -> Subtrair: {calc.Invoke(2, 3)}");

calc = Calculadora.Multiplicar;
Console.WriteLine($"DelegateCalculadora -> Multiplicar: {calc.Invoke(7, 7)}");

calc = Calculadora.Dividir; 
Console.WriteLine($"DelegateCalculadora -> Dividir: {calc.Invoke(150, 3)}");

static void MeuMetodo(string str) { Console.WriteLine(str); }

public delegate void MeuDelegate(string str);
public delegate double DelegateCalculadora(double x, double y);
