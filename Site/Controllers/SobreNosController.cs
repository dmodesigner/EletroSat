using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers
{
    public class SobreNosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
