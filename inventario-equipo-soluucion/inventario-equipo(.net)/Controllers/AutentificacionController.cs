using Microsoft.AspNetCore.Mvc;

namespace inventario_equipo_.net_.Controllers
{
    public class AutentificacionController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
		public IActionResult Registro()
		{
			return View();
		}
		public IActionResult Recuperar_clave()
		{
			return View();
		}
		public IActionResult Recuperar_clave2()
		{
			return View();
		}
		public IActionResult Verificacion_email()
		{
			return View();
		}
	}
}
