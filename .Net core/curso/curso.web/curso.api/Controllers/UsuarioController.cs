using curso.api.Model;
using Microsoft.AspNetCore.Mvc;

namespace curso.api.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput) 
        {
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("registrar")]
        public IActionResult Registro(RegistrarViewModelInput registrarViewModelInput)
        {
            return Created("", registrarViewModelInput);
        }

    }
}
