using ApiRecord.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiRecord.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuariosController : ControllerBase
{
    [HttpPost]
    public IActionResult Criar(CriarUsuarioRequest request)
    {
        // Veja como é simples transformar um DTO em uma entidade.
        // Sem set, sem mutação, sem risco
        var usuario = new Usuario(Guid.NewGuid(), request.Nome, request.Email);
        return Ok(usuario);
    }

    [HttpGet("exemplo-com-with")]
    public IActionResult ExemploComWith()
    {
        var usuarioAtual = new Usuario(Guid.NewGuid(), "João", "joao@email.com");

        // Simula atualização de e-mail
        var usuarioAtualizado = usuarioAtual with
                                { 
                                    Email = "novousuario@email.com" 
                                };

        // usuarioAtual continua intocado.
        // Isso é imutabilidade com estilo!”
        return Ok(new { usuarioAtual, usuarioAtualizado });
    }

    [HttpGet("comparar-objetos")]
    public IActionResult Comparar()
    {
        var id = Guid.NewGuid();
        var u1 = new Usuario(id, "Jose", "jose@email.com");
        var u2 = new Usuario(id, "Jose", "jose@email.com");

        // Mesmo com objetos diferentes na memória,
        // eles são considerados iguais.
        // Isso é comparação por valor!”
        bool iguais = u1 == u2;
        return Ok(new { u1, u2, iguais });
    }
}