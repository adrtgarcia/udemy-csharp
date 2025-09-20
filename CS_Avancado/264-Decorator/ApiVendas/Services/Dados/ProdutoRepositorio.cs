using ApiVendas.Entities;

namespace ApiVendas.Services.Dados;

public class ProdutoRepositorio
{
    // Lista estática simulando um banco de dados
    public static readonly List<Produto> _produtos = new List<Produto>
    {
        new Produto { Id = 1, Nome = "Notebook Xpert", PrecoBase = 4000m },
        new Produto { Id = 2, Nome = "Mouse Gamer", PrecoBase = 200m },
        new Produto { Id = 3, Nome = "Teclado Mecânico", PrecoBase = 50m },
        new Produto { Id = 4, Nome = "Monitor 27\"", PrecoBase = 1000m },
        new Produto { Id = 5, Nome = "Fones de Ouvido", PrecoBase = 100m }
    };
    public Produto? ObterPorId(int id) => _produtos.FirstOrDefault(p => p.Id == id);
}
