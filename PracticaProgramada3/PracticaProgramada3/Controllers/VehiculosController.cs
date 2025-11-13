using Microsoft.AspNetCore.Mvc;

namespace PracticaProgramada3.Controllers
{
    public class VehiculosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
