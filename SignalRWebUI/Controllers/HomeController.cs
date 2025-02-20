using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
