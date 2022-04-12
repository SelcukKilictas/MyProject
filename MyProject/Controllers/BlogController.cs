using BusinessLayer.Concrate;
using BusinessLayer.ValidationRules;
using DataAccesLayer.EntityFrameWork;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace MyProject.Controllers
{
    [AllowAnonymous]

    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var values = bm.GetBlogListByWriter(1);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryManager cm=new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            ViewBag.cV=categoryValues;

            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {


            BlogValidator bV = new BlogValidator();

            FluentValidation.Results.ValidationResult results = bV.Validate(p);
            if (results.IsValid)
            {
                p.BlogStatus = true;

                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = 1;
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();

            }
        }
    }
   
}
