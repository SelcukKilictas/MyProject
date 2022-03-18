using DataAccesLayer.Abstract;
using DataAccesLayer.Concrate;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        


        public void AddBlog(Blog blog)
        {
            using var myContext=new MyContext();
            myContext.Add(blog);
            myContext.SaveChanges();
        }

        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            using var myContext = new MyContext();
            myContext.Remove(blog);
            myContext.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var myContext = new MyContext();
            return myContext.Blogs.Find(id);
        }

        public Blog GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            using var myContext = new MyContext();
            return myContext.Blogs.ToList();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            using var myContext = new MyContext();
            myContext.Update(blog);
            myContext.SaveChanges();
        }
    }
}
