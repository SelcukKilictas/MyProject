using BusinessLayer.Concrate;
using DataAccesLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm=new AboutManager(new EfAboutRepository());

        public IActionResult Index()
        {
            var values = abm.GetList();
            return View(values);
        }

        public PartialViewResult SocialMediaAbout()
        {
          
            return PartialView();
        }
    }
}
