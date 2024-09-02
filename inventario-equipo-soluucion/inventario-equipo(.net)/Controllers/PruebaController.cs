using Microsoft.AspNetCore.Mvc;

namespace inventario_equipo_.net_.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult Pagina_muestra()
        {
            return View();
        }
    }
}
