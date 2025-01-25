using Microsoft.AspNetCore.Mvc;

namespace ProjeKampi_Mvc.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test2()
        {
            return View();
        }
    }
}
