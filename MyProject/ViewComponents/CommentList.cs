using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.ViewComponents
{
    public class CommentList:ViewComponent
    {

        public IViewComponentResult Invoke() 
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName ="Selçuk"
                },
                new UserComment
                {
                    ID=2,
                    UserName ="Aydoğan"
                },
                new UserComment
                {
                    ID=3,
                    UserName ="İrem"
                }
            };
            return View(commentvalues);
        }
    }
}
