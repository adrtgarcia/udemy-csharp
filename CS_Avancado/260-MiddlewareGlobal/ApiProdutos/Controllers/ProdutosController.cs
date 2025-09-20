using ApiProdutos.Entities;
using ApiProdutos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiProdutos.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly IProdutoRepository _repositorio;

    public ProdutosController(IProdutoRepository repositorio)
    {
        _repositorio = repositorio;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var produtos = await _repositorio.ObterTodosAsync();
            return Ok(produtos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao obter produtos: {ex.Message}");
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        try
        {
            var produto = await _repositorio.ObterPorIdAsync(id);

            if (produto is null)
                return NotFound("Produto não encontrado.");
            
            return Ok(produto);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao obter produto por ID: {ex.Message}");
        }
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Produto produto)
    {
        try
        {
            await _repositorio.AdicionarAsync(produto);
            return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao adicionar produto: {ex.Message}");
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] Produto produto)
    {
        try
        {
            if (id != produto.Id)
                return BadRequest("ID do produto não confere.");

            var existente = await _repositorio.ObterPorIdAsync(id);
            if (existente is null)
                return NotFound("Produto não encontrado.");

            await _repositorio.AtualizarAsync(produto);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao atualizar produto: {ex.Message}");
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var existente = await _repositorio.ObterPorIdAsync(id);
            if (existente is null)
                return NotFound("Produto não encontrado.");

            await _repositorio.RemoverAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao remover produto: {ex.Message}");
        }
    }
}
