# C# - Conceitos Avançados com Aplicações Práticas

## Ranges e Índices

### Índices
    ^ acessa o final da coleção
    (^1 o último, ^2 o penúltimo...)
 
### Ranges
    .. signifca "do começo ao fim"
    [..] retorna todo o conteúdo
    [n..] vai do índice n até o final
    [..n] vai do início até o índice n


## Primary Constructors
Permitem definir o construtor diretamente na declaração da classe, como é feito com os Records.
* Funcionam com `class`, `struct`, `interface` e `abstract class`.


## Span e ReadOnlySpan
`Span<T>` é um ref struct que representa uma região contígua de memória (array, string, buffer...), permitindo o manuseio de partes de grandes blocos, sem precisar copiá-los.
* Tipo seguro, impede erros comuns de acesso à memória.
* Não aloca memória heap, reduzindo pressão sobre garbage collector.
* Reside na stack, uma área de memória rápida e de curta duração.

`ReadOnlySpan<T>` é a versão somente leitura de `Span<T>`

### Métodos
`.AsSpan()` retorna um Span ou ReadOnlySpan a partir de diversas coleções e tipos de dados existentes.

`.Slice(int start)` retorna um novo Span que começa em um dado 
índice e vai até o final do Span original.

`.Slice(int start, int length)` retorna um novo Span sobre uma porção exata dos dados originais, sem alocar memória nova.

`.IndexOf(T value)` retorna a primeira ocorrência de um valor ou sequência de valores. 


## CallerArgumentExpression
`CallerArgumentExpression` é um recurso que permite capturar de forma automática a expressão usada como argumento de uma chamada de método.
* Evita o uso de nameof() e a duplicação de código
       
```
[CallerArgumentExpression("argumento")]
```
 

## Métodos de Extensão com LINQ
**Extension Methods** são uma implementação do padrão **Composite**, e permitem que seja adicionado uma nova funcionalidade a um tipo de dado que já foi definido sem ter que criar um novo tipo derivado. Dessa forma, a funcionalidade se comporta como um outro membro do tipo.
* São definidos como estáticos, mas são chamados usando a sintaxe do método de instância.
* Seu primeiro parâmetro especifica em que tipo o método opera e o parâmetro é precedido pelo modificador **this**.

```
public static class NomeClasseExtensao 
{
    public static TipoRetorno NomeMetodo(this TipoSeraEstendido parâmetro, outros parâmetros...)
    {
        // lógica do método
    }
}
```


## List, ICollection, IEnumerable, ToList e IQueryable
`IEnumerable<T>` é uma interface de leitura sequencial, ideal para expor dados de forma segura e flexível, permitindo que o consumidor apenas leia os itens, sem saber como são armazenados.
* Representa uma sequência de itens.
* Apenas para leitura e iteração foreach.
* Execução adiada (só executa na iteração).

`List<T>` é uma classe concreta, usada quando se quer uma coleção ordenada, mutável e com acesso rápido por índice, mas deve ser usada com moderação (especialmente na hora de expor dados).
* Permite adicionar, remover, acessar qualquer item diretamente, contar itens, etc.
* É uma sequência concretizada, guardada em memória.
 
`ICollection<T>` estende **IEnumerable** e permite modificar a coleção, ideal para quando o método precisa alterar o conteúdo da lista passada.
* **IEnumerable** modificável.
* Permite adicionar e remover itens, e obter o tamanho da coleção com Count.
 
`IQueryable<T>` representa uma consulta que ainda não foi executada e permite construir filtros e projeções que serão traduzidos para SQL, perfeito para trabalhar com banco de dados via LINQ.
* Parecido com **IEnumerable**, mas trabalha com árvores de expressão.
* Ao escrever uma consulta LINQ, ela não é executada, mas é traduzida para SQL.
