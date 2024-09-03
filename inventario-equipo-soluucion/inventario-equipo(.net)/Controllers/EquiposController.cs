using Microsoft.AspNetCore.Mvc;

namespace inventario_equipo_.net_.Controllers
{
    public class EquiposController : Controller
    {
        public IActionResult Verequipos()
        {
            return View();
        }
        public IActionResult Agregarequipos()
        {
            return View();
        }
        public IActionResult VerAsignaciones()
        {
            return View();
        }
        public IActionResult AgregarAsignacion()
        {
            return View();
        }
    }
}
