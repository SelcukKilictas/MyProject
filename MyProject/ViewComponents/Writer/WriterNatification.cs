using Microsoft.AspNetCore.Mvc;

namespace MyProject.ViewComponents.Writer
{
    public class WriterNatification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
