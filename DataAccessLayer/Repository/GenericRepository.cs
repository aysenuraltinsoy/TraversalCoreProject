﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var x = new Context();
            x.Remove(t);
            x.SaveChanges();

        }

        public T GetByID(int id)
        {
            using var c =new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var x = new Context();
            return x.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var x = new Context();
            x.Add(t);
        }

        public void Update(T t)
        {
            using var x = new Context();
            x.Update(t);
        }
    }
}
