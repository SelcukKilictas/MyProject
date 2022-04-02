using Microsoft.AspNetCore.Mvc;

namespace MyProject.ViewComponents.Writer
{
    public class WriterMessageNatification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
