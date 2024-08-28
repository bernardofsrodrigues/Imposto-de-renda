using Estrutura_Base.Services;
using Microsoft.AspNetCore.Mvc;

namespace Estrutura_Base.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        private readonly FibonacciService _service;

        public FibonacciController(FibonacciService service)
        {
            _service = service;
        }

        [HttpPost("calcular")]
        public ActionResult<float> GetFibonacci([FromBody] float number)
        {
            float result = _service.CalculateFibonacci(number);
            return Ok(result);
        }
    }
}