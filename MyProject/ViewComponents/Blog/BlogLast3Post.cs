﻿using BusinessLayer.Concrate;
using DataAccesLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.ViewComponents.Blog
{
    public class BlogLast3Post:ViewComponent
    {
        BlogManager bm=new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.GetLast3Blog();
            return View(values);
        }

    }
}
