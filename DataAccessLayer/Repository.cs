using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        DbContext c;
        DbSet<T> _object;
        public Repository(DbContext context)
        {
            c = context;
            _object = c.Set<T>();
        }
        public int Delete(T p)
        {
            _object.Remove(p);
            return c.SaveChanges();
        }

        public T GetById(int id)
        {
           return _object.Find(id);    
        }

        public int Insert(T p)
        {
            _object.Add(p);
            return c.SaveChanges();
            
            
        }

        public List<T> GetAll()
        {
          return _object.ToList();
        }

        public int Update(T p)
        {
            _object.Update(p);
            return c.SaveChanges();
        }
    }
}
