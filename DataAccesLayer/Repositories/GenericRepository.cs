using DataAccesLayer.Abstract;
using DataAccesLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        private readonly MyContext _myContext;

        public GenericRepository(MyContext myContext)
        {
            _myContext = myContext;
        }
        public void Delete(T t)
        {
            _myContext.Remove(t);
            _myContext.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _myContext.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
           return _myContext.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _myContext.Add(t);
            _myContext.SaveChanges();
        }

        public void Update(T t)
        {
            _myContext.Update(t);
            _myContext.SaveChanges();
        }
    }
}
