using curso.Models;
using Microsoft.AspNetCore.Mvc;

namespace curso.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(RegistrarUsuarioViewModelInput registrarUsuarioViewModelInput)
        {
            return View();
        }
    }
}
