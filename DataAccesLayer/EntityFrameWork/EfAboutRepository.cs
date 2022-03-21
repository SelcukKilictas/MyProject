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
    public class EfAboutRepository : GenericRepository<About>, IAboutDal
    {
        
    }
}
