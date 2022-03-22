using DataAccesLayer.Abstract;
using DataAccesLayer.Concrate;
using DataAccesLayer.Repositories;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFrameWork
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {   using(var c=new MyContext()) 
            return c.Blogs.Include(x=>x.Category).ToList(); 
        }
    }
}
