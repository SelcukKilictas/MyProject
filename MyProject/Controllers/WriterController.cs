using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class WriterController : Controller
    {

        

        public IActionResult Index()
        {
            return View();
        }
    }
}
