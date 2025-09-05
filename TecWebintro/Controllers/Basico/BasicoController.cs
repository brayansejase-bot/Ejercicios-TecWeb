using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TecWebintro.Controllers.Basico
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicoController : ControllerBase
    {
        [HttpGet] 
        public IActionResult Get()
        {
            return Ok("Hola Mundo");
        }

        [HttpGet("Saludar/{nombre}")]
        public IActionResult Saludar(string nombre)
        {
            return Ok($"Hola, {nombre}");
        }

        [HttpGet("sumar/{a}/{b}")]
        public IActionResult Sumar(int a,int b)
        {
            int resultado = a + b;
            return Ok($"La suma de {a} + {b} es: {resultado}");
        }

        [HttpGet("ParImpar/{a}")]
        public IActionResult VerificarParImpar(int a)
        {
            if (a % 2 == 0)
            {
                return Ok($"El numero {a} es Par");
            }
            else
            {
                return Ok($"El numero {a} es Impar");
            }
        }

       
    }
}
