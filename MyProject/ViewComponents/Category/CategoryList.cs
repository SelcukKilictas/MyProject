using BusinessLayer.Concrate;
using DataAccesLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
