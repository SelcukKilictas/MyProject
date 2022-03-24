using BusinessLayer.Concrate;
using DataAccesLayer.EntityFrameWork;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MyProject.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            p.ContactStatus = true;
            cm.ContactAdd(p);
            return RedirectToAction("Index","Blog");
        }
    }
}
