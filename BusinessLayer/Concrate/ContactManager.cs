﻿using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetByID(id); 
        }

        public List<Contact> GetList()
        {
          return _contactDal.GetListAll();
        }

        public void TAdd(Contact t)
        {
           _contactDal.Insert(t);   
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public void TUpdate(Contact t)
        {
           _contactDal.Update(t);
        }
    }
}
