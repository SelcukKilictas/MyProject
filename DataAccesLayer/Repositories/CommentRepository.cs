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
    public class CommentRepository : IGenericDal<Comment>
    {

        private readonly MyContext _myContext;

        public CommentRepository(MyContext myContext)
        {
            _myContext = myContext;
        }
        public void Delete(Comment t)
        {
            _myContext.Remove(t);
            _myContext.SaveChanges();
        }

        public Comment GetByID(int id)
        {
            return _myContext.Set<Comment>().Find(id);
        }

        public List<Comment> GetListAll()
        {
         return _myContext.Set<Comment>().ToList();
        }

        public void Insert(Comment t)
        {
            _myContext.Add(t);
            _myContext.SaveChanges();
        }

        public void Update(Comment t)
        {
            _myContext.Update(t);
            _myContext.SaveChanges();
        }
    }
}
