using Microsoft.AspNetCore.Mvc;

namespace Quiz_2.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
