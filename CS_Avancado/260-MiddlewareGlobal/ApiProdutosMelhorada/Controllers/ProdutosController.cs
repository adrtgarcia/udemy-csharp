using ApiProdutosMelhorada.Entities;
using ApiProdutosMelhorada.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiProdutosMelhorada.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly IProdutoRepository _repositorio;
    private readonly ILogger<ProdutosController> _logger;

    public ProdutosController(IProdutoRepository repositorio, ILogger<ProdutosController> logger)
    {
        _repositorio = repositorio;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var produtos = await _repositorio.ObterTodosAsync();
        return Ok(produtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var produto = await _repositorio.ObterPorIdAsync(id);

        if (produto is null)
        {
            _logger.LogWarning("Produto não encontrado para o ID: {Id}", id);
            return NotFound();
        }

        return Ok(produto);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Produto produto)
    {
        if (produto.Nome?.Length > 50)
            throw new InvalidOperationException("Nome do produto muito longo.");

        await _repositorio.AdicionarAsync(produto);
        return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] Produto produto)
    {
        if (id != produto.Id)
            return BadRequest("ID do produto não confere.");

        var existente = await _repositorio.ObterPorIdAsync(id);
        if (existente is null)
            return NotFound();

        await _repositorio.AtualizarAsync(produto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var existente = await _repositorio.ObterPorIdAsync(id);

        if (existente is null)
            return NotFound();

        await _repositorio.RemoverAsync(id);
        return NoContent();
    }
}