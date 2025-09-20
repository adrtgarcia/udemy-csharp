using ApiProdutos.Context;
using ApiProdutos.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProdutos.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Produto>> ObterTodosAsync()
    {
        try
        {
            return await _context.Produtos.ToListAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao obter todos os produtos", ex);
        }
    }

    public async Task<Produto> ObterPorIdAsync(int id)
    {
        try
        {
            var produto = await _context.Produtos.FirstOrDefaultAsync(p => p.Id == id);
            if (produto == null)
            {
                throw new Exception($"Produto com ID {id} não encontrado.");
            }
            return produto;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao obter produto por ID", ex);
        }
    }

    public async Task AdicionarAsync(Produto produto)
    {
        try
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao adicionar produto", ex);
        }
    }

    public async Task AtualizarAsync(Produto produto)
    {
        try
        {
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao atualizar produto", ex);
        }
    }

    public async Task RemoverAsync(int id)
    {
        try
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto is not null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao remover produto", ex);
        }
    }
}