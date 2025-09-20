using ApiVendas.Entities;
using ApiVendas.Services.Abstractions;
using ApiVendas.Services.ImplaSemDecorator;
using Microsoft.AspNetCore.Mvc;

namespace ApiVendas.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VendasController(
    CalculadoraPrecoProdutoLegado calculadoraLegado,
    ICalculadoraPrecoProduto calculadoraComDecorator) : ControllerBase
{
    [HttpPost("sem-decorator")]
    public IActionResult CalcularSemDecorator([FromBody] VendaRequest requisicao)
    {
        try
        {
            var precoFinal = calculadoraLegado.Calcular(requisicao.ProdutoId);
            return Ok(new { resultado = $"Preço final (sem decorator): {precoFinal:C}" });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("com-decorator")]
    public IActionResult CalcularComDecorator([FromBody] VendaRequest requisicao)
    {
        try
        {
            // A mágica da injeção de dependência já montou a cadeia de decorators!
            var precoFinal = calculadoraComDecorator.Calcular(requisicao.ProdutoId);
            return Ok(new { resultado = $"Preço final (com decorator): {precoFinal:C}" });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
