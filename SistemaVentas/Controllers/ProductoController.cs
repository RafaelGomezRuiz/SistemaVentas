using Microsoft.AspNetCore.Mvc;

namespace WebApp.SistemaVentas.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
