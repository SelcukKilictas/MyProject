using BusinessLayer.Concrate;
using DataAccesLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class Category : Controller
    {
        private readonly CategoryManager _categoryManager;

        public Category(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public IActionResult Index()
        {
            var values = _categoryManager.GetList();
            return View(values);
        }
    }
}
