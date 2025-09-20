using Microsoft.EntityFrameworkCore;

Console.WriteLine("Operadores de Junção");
/* a aula utiliza sql server para demonstrar a funcionalidade dos operadores */

/*
 
    JOIN é usado para unir duas fontes de dados, ou coleções, com base na propriedade comum e 
    retornar os dados como um único conjunto de resultados

    GROUP JOIN é usado para unir duas fontes de dados, ou coleções, com base em uma chave ou
    propriedade comum, mas retorna o resultado como um grupo de sequências
  
 */

/*
 
    uma cláusula join recebe duas sequências de origem como entrada, e os elementos em cada
    sequência devem ser, ou conter, uma propriedade que possa ser comparada com uma propriedade
    correspondente na outra sequência
        - join compara a igualdade das chaves especificadas, usando EQUALS
    
    tipos de junção
        - inner: apenas os itens em comum
        - right: itens em comum e tabela 2                      <- linq não aceita, precisa inverter as tabelas (2->1, 1->2)
        - left: itens em comum e tabela 1
        - full: todos os itens de ambas as tabelas              <- fazer left, right e aplicar union
        - cross: produto cartesiano                             <- duas cláusulas from e em seguida select
 
 */

/* exemplo de innerJoin:

var innerJoin = contexto.Funcionarios.Join(
        contexto.Setores,
            funcionario => funcionario.SetorId,
            setor => setor.Id,
            (Funcionario, Setor) => new
            {
                nomeFunc = funcionario.Nome,
                nomeSet = setor.Nome,
                cargoFunc = funcionario.Cargo
            }).ToList();
 */

/* exemplo com groupJoin:

var groupJoin = contexto.Setores.GroupJoin(
        contexto.Funcionarios,
        setor => setor.Id, f => funcionario.SetorId,
        (f, funcionariosGrupo) => new
        {
            Funcionarios = funcionariosGrupo,
            NomeSetor = f.SetorNome
        }).ToList();
 */

public class Funcionario
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cargo { get; set; }
    public int? SetorId { get; set; }
}
public class Setor
{
    public int Id { get; set; }
    public string? Nome { get; set; }
}
