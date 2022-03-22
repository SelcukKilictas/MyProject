using BusinessLayer.Concrate;
using BusinessLayer.ValidationRules;
using DataAccesLayer.EntityFrameWork;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p) 
        {
            WriterValidator wV=new WriterValidator();

            ValidationResult results=wV.Validate(p);
            if(results.IsValid)
            {
                p.WriterStatus = true;

                p.WriterAbout = "Deneme test";

                wm.WriterAdd(p);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
                return View();
            }
        }
    }
}
