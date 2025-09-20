Console.WriteLine("Multicast Delegate");

/*
 
    SingleCast Delegate: referencia e invoca um único método
    MultiCast Delegate: referencia e invoca mais de um método

    quando invocamos o multicast delegate, todos os métodos referenciados
    serão invocados em ordem
        - é útil em situações em que várias ações precisam ser executadas
          quando um evento ocorrer
        - para adicionar métodos, usamos +=
        - para remover métodos, usamos -=
  
 */

MeuDelegate del = Metodo1;
del += Metodo2;
del("hello world");

del -= Metodo1;
del("hello world");

static void Metodo1(string str)
{
    Console.WriteLine($"Método 1: {str}");
}
static void Metodo2(string str)
{
    Console.WriteLine($"Método 2: {str}");
}

public delegate void MeuDelegate(string str);