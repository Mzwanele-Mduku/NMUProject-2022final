using Microsoft.AspNetCore.Mvc;

namespace Innovators.Controllers
{
    public class HODController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
