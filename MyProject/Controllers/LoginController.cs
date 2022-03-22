using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
