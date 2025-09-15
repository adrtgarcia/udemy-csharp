Console.WriteLine("Generics");

/*
 
    GENERICS: não específico para um determinado tipo de dados
        - permite definir classes, interfaces, campos, métodos, propriedades, eventos, delegates e operadores genéricos
          usando o parâmetro de tipo e sem o tipo de dados específico
        - permite que classes, mpetodos e interfaces possam ser parametrizados por tipo
 
    SINTAXE:
        NomeTipo<T>         onde T é o parâmetro de tipo
 
            public class ClasseGeneric<T> { ... }
            public class ClasseGeneric<T1, T2> { ... }
            public class InterfaceGeneric<T> { ... }
            public class InterfaceGeneric<T1, T2, ..., TN> { ... }
            public class MetodoGeneric<T> (T a) { ... }

    RESTRIÇÕES: restringem o código do cliente para especificar determinados tipos ao instaciar tipos genéricos
        - podemos definir uma ou mais restrições no tipo genérico usando a cláusula WHERE após o nome do tipo
          genérico seguido de dois pontos e a seguir a restrição que desejamos definir
        - mais usadas: struct, class, new(), classe base, interface
        
        NomeTipo<T> where T : restrição
            
            public class ClasseGeneric<T> where T : struct
            public class ClasseGeneric<T1, T2> where T1 : struct where T2 : class
            public class InterfaceGeneric<T> where T : class, new()
            public class MetodoGeneric<T>(T a) where T : class
            
    BENEFÍCIOS:
        - reutilização de código
        - segurança de tipo
        - desempenho (evita operações de boxing e unboxing)

 */

Teste1 t1 = new();

int num1 = 10;
int num2 = 10;
t1.Comparar1(num1, num2);

float num3 = 10;
float num4 = 30;
t1.Comparar1(num3, num4);

t1.Comparar1(num1, num2);
t1.Comparar1(num1, num3);

/* 
Teste2<string, string> t2 = new();   <- precisa ser tipo de valor
string str1 = "10";
string str2 = "20";
t2.Comparar2(str1, str2); 
*/

Teste2<int, int> t2 = new();
t2.Comparar2(num1, num2);
t2.Comparar2(num3, num4);
t2.Comparar2(num1, num3);

public class Teste1
{
    public void Comparar1<T>(T a, T b)
    {
        Console.WriteLine();
        Console.WriteLine($"1º valor: {a} - {a?.GetType()}");
        Console.WriteLine($"2º valor: {b} - {b?.GetType()}");
        var resultado = a?.Equals(b);
        Console.WriteLine($"{a} e {b} são iguais? {resultado}");
    }
    /* 
    public void Comparar2<T1, T2>(T1 a, T2 b)
    {
        Console.WriteLine();
        Console.WriteLine($"1º valor: {a} - {a?.GetType()}");
        Console.WriteLine($"2º valor: {b} - {b?.GetType()}");
        var resultado = a?.Equals(b);
        Console.WriteLine($"{a} e {b} são iguais? {resultado}");
    } 
    */
}


public class Teste2<T1, T2> where T1 : struct where T2 : struct
{
    public void Comparar2<T1, T2>(T1 a, T2 b)
    {
        Console.WriteLine();
        Console.WriteLine($"1º valor: {a} - {a?.GetType()}");
        Console.WriteLine($"2º valor: {b} - {b?.GetType()}");
        var resultado = a?.Equals(b);
        Console.WriteLine($"{a} e {b} são iguais? {resultado}");
    }
}