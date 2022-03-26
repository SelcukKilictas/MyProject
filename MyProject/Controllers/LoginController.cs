using DataAccesLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyProject.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task <IActionResult> Index(Writer p)
        {
            MyContext myContext = new MyContext();
            
            var dataValue=myContext.Writers.FirstOrDefault(x=>x.WriterMail==p.WriterMail &&
            x.WriterPassword==p.WriterPassword);
            if (dataValue != null)
            {
              var claims = new List<Claim>
              {
                  new Claim(ClaimTypes.Name,p.WriterMail)
              };

                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal=new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
               return RedirectToAction("Index","Writer");
            }
            else
            {
                return View();
            }
           
        }
        //MyContext myContext = new MyContext();

        //var dataValue=myContext.Writers.FirstOrDefault(x=>x.WriterMail==p.WriterMail &&
        //x.WriterPassword==p.WriterPassword);
        //if (dataValue != null)
        //{
        //    HttpContext.Session.SetString("username", p.WriterMail);
        //    return RedirectToAction("Index","Writer");
        //}
        //else
        //{
        //    return View();
        //}

    }
}
