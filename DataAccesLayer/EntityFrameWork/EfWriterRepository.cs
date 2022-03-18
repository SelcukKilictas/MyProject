using DataAccesLayer.Abstract;
using DataAccesLayer.Concrate;
using DataAccesLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFrameWork
{
    public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
    {
        public EfWriterRepository(MyContext myContext) : base(myContext)
        {
        }
    }
}
