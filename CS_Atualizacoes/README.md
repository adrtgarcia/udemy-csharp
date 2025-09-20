# Atualizações do C# - Recursos das Novas Versões do C#

## C# 9

### RECORD
O **Record Type** é um tipo de referência, como uma classe, mas que funciona como um tipo de valor. Além de imutável, ainda fornece suporte para a expressão **with**, herança, construtores e deconstrutores. 
* Um record pode ser implementado da mesma forma que a classe, mas sua sintaxe simplificada é mais comum.

```
    public record Cliente(string? Nome, int Idade)
```
```
    var cliente2 = cliente1 with {Idade=35}
```

* **DTO**: Tipo serializado, usado em transferências entre aplicação e banco de dados. Por meio dos Records, tem-se a garantia de que o objeto não será alterado.

<br>

> **Tipo de Valor** <br>
> Utilizando **equals** ou **==** para comparações, o retorno será **true** se os dois tipos armazenam o mesmo valor.

> **Tipo de Referência** <br>
> Utilizando **equals** ou **==** para comparações, o retorno será **true** se os dois tipos apontam para o mesmo endereço na memória.


### DECONSTRUCTOR
O **Deconstructor** destrói um objeto, retornando os valores contidos nele por meio de uma tupla, e pode ser declarado da seguinte maneira:
```
    public void deconstruct (out arg1, out arg2, ..., out argn)
```


### INIT-ONLY PROPERTIES
Significa usar `{ get; init; }` em uma propriedade, permitindo a criação de propriedades imutáveis, sem a necessidade de um construtor. 
* O valor defindo na criação do objeto será definitivo.

De forma simplificada:
* `{ get; }` declara uma propriedade read-only.
* `{ get; init; }` declara uma propriedade imutável.
* `{ get; set; }` declara uma propriedade mutável.


## C# 10
Suas principais mudanças são:

* Declaração de namespace com escopo de arquivo.
* Interpolação de strings constantes.
* Declaração `sealed override string ToString()` para records.
* Declaração `record struct` e `readonly record struct`.
* Verificação de nulos com `ThrowifNull()`.
* `DateOnly` e `TimeOnly` como alternativas ao DateTime.
* Tipo natural para expressão lambda ou grupo de métodos lambda.
* Definição de tipo de retorno e de atributos em expressões lambda.

Além disso, houve também a introdução do `global using` e do `implicit using`:
* O **global using** permite declarar apenas uma vez a diretiva using em um namespace em um mesmo projeto, identificando diretivas using que serão aplicadas a todos os arquivos da solução.
* O **implicit using** adiciona automaticamente diretivas **global using** comuns para o tipo de projeto que está em construção, e vem habilitado por padrão no arquivo `.csproj`.


## C# 11
Suas principais mudanças são:
* Modificador `required` para propriedades e campos.
* Modificador de acesso `file`.
* Extensão do escopo de `nameof`.
* Inicialização padrão de valores por meio do construtor de structs.
* Declaração de classes genéricas que herdam de `System.Atrribute`.
* Interpolação de string com newlines.
* `Raw String Literal` por meio de """ no início e no final de strings.
* List pattern matching por meio de `discard pattern (_)`, `range pattern (..)` e `var pattern`.


## C# 12
Suas principais mudanças são:
* Criação de **aliás** por meio de `using` para namespace e tupla anônima.
* Valor padrão como parâmetro em expressões lambda.
* Construtores primários.

Além disso, a declaração de coleções também mudou:
```
    int[] numeros = new int[] {1,2,3};  // antes
    int[] numeros = [1,2,3];            // depois
``` 
```
    int[] pares = [2,4,6]
    int[] impares = [1,3,5]
    int[][]números = [pares, impares]
```
```
    List<int> lista1 = [1,2,3];
    List<int> lista2 = [4,5,6];
    List<int> combinação = [.. lista1, ..lista2];
```

<br><hr>
<div align='center'>
    📌 <a align='center' href="www.youtube.com/@josecarlosmacoratti">(YouTube)</a> Jose Carlos Macoratti
</div>
