using Microsoft.AspNetCore.Mvc;

namespace BlogWebApplication.Controllers
{
    public class DestinosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PraiaDoUna()
        {
            return View();
        }
        public IActionResult CamposDoJordao()
        {
            return View();
        }
    }
}
