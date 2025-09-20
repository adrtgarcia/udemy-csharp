using ApiProdutosMelhorada.Context;
using ApiProdutosMelhorada.CustomExceptions;
using ApiProdutosMelhorada.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProdutosMelhorada.Repositories;

// Repositório refatorado SEM catch genérico — deixa a exceção propagar
public class ProdutoRepository : IProdutoRepository
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Produto>> ObterTodosAsync()
    {
        return await _context.Produtos.ToListAsync();
    }

    public async Task<Produto> ObterPorIdAsync(int id)
    {
        var produto = await _context.Produtos.FirstOrDefaultAsync(p => p.Id == id);

        if (produto is null)
            throw new ProdutoNotFoundException($"Produto com ID {id} não encontrado.");

        return produto;
    }

    public async Task AdicionarAsync(Produto produto)
    {
        _context.Produtos.Add(produto);
        await _context.SaveChangesAsync();
    }

    // aqui poderiamos lança um exceção específica
    // se o produto não existir
    // OU ERROS COMO DbUUpdateException
    public async Task AtualizarAsync(Produto produto)
    {
        _context.Produtos.Update(produto);
        await _context.SaveChangesAsync();
    }

    public async Task RemoverAsync(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);
        if (produto is not null)
        {
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
        }
    }
}

