using System.Dynamic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TecWebintro.Models;

namespace TecWebintro.Controllers.Basico
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListasController : ControllerBase
    {
        #region region
        [HttpGet("generica")]
        public IActionResult ListaGenerica()
        {
            var personas = new List<Persona>()
            {
                new Persona { Id=1, Nombre = "Juan", Edad = 20},
                new Persona { Id=2, Nombre = "Maria", Edad = 40}
            };
            return Ok(personas);
        }
        #endregion
        #region Diccionario
        [HttpGet("diccionario")]
        public IActionResult ObtenerDiccionario()
        {
            var diccionario = new Dictionary<string, string>()
            {
                { "clave1", "valor1"},
                { "clave2", "valor2"}
            };
            return Ok(diccionario);
        }

        private object Dictionary<T1, T2>()
        {
            throw new NotImplementedException();
        }
        #endregion

        
    }
}
