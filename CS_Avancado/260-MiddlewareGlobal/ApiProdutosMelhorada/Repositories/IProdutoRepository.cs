using ApiProdutosMelhorada.Entities;

namespace ApiProdutosMelhorada.Repositories;

public interface IProdutoRepository
{
    Task<Produto> ObterPorIdAsync(int id);
    Task<IEnumerable<Produto>> ObterTodosAsync();
    Task AdicionarAsync(Produto produto);
    Task AtualizarAsync(Produto produto);
    Task RemoverAsync(int id);
}
