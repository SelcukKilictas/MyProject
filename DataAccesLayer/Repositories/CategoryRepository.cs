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
    public class CategoryRepository : ICategoryDal
    {
        private readonly MyContext _myContext;

        public CategoryRepository(MyContext myContext)
        {
            _myContext = myContext;
        }
        public void AddCategory(Category category)
        {
            _myContext.Add(category);
            _myContext.SaveChanges();
        }

        public void Delete(Category t)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            _myContext.Remove(category);
            _myContext.SaveChanges();
        }

        public Category GetById(int id)
        {
           return _myContext.Categories.Find(id);
        }

        public Category GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
            return _myContext.Categories.ToList();
        }

        public void Update(Category t)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            _myContext.Update(category);
            _myContext.SaveChanges();
        }
    }
}
