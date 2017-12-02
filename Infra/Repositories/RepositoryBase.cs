using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.Context;
using System.Collections.Generic;
using System.Data.Entity;
using Domain.Interfaces;

namespace Infra.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public readonly DataContext Db;

        public RepositoryBase()
        {
            Db = new DataContext();
        }

        public void Add(T obj)
        {
            Db.Set<T>().Add(obj);
            Db.SaveChanges();
        }

        public void Delete(int id)
        {
            var dado = Db.Set<T>().Find(id);
            Db.Entry<T>(dado).State = EntityState.Deleted;
            Db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return Db.Set<T>();
        }

        public T GetById(int id)
        {
            return Db.Set<T>().Find(id);
        }

        public void Update(T obj)
        {
            Db.Entry<T>(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
