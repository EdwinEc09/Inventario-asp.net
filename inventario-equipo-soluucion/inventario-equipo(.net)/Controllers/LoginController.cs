using Microsoft.AspNetCore.Mvc;

namespace inventario_equipo_.net_.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
