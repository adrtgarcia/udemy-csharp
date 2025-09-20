using ApiProdutos.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProdutos.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Produto> Produtos => Set<Produto>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuração inicial para a entidade Produto
        modelBuilder.Entity<Produto>().HasData(
            new Produto
            {
                Id = 1,
                Nome = "Caderno Espiral",
                Preco = 15.45M,
                Estoque = 50
            },
            new Produto
            {
                Id = 2,
                Nome = "Caneta Esferográfica",
                Preco = 2.00M,
                Estoque = 200
            },
            new Produto
            {
                Id = 3,
                Nome = "Mochila Escolar",
                Preco = 85.99M,
                Estoque = 30
            }
        );
    }
}
