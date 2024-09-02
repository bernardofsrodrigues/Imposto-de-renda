using Microsoft.AspNetCore.Mvc;
using Estrutura_Base.Models;
using Estrutura_Base.Services;

namespace Estrutura_Base.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImpostoController : ControllerBase
    {
        private readonly ImpostoService _impostoService;

        public ImpostoController(ImpostoService impostoService)
        {
            _impostoService = impostoService;
        }

        [HttpPost("calcular")]
        public ActionResult<decimal> CalcularImposto([FromBody] ImpostoRequest request)
        {
            // Se a string da renda for nula ou apenas espaços retorna um erro 400 personalizado
            if (string.IsNullOrWhiteSpace(request.Renda))
            {
                return BadRequest("A renda deve ser preenchida com um valor positivo.");
            }

            try
            {
                // Processa a renda e calcula o imposto
                decimal renda = _impostoService.ProcessarRenda(request.Renda);
                decimal imposto = _impostoService.CalcularImpostoDeRenda(renda);

                // Retorna o imposto calculado em formato JSON
                return Ok(new { imposto });
            }
            catch (FormatException ex)
            {
                // Retorna um erro 400 para formato inválido
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                // Tratamento de erro em casos não esperados
                return StatusCode(500, $"Ocorreu um erro ao calcular o imposto: {ex.Message}");
            }
        }
    }
}
