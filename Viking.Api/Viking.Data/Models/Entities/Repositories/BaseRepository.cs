using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viking.Data.Models.Entities.Repositories
{
    interface IRepository<T> where T : class
    {
        List<T> getAll();
        void add(T entity);
        void delete(int id);
        void update(T entity);
    }
    class BaseRepository<T> : IRepository<T> where T : class
    {
        vikingEntities db = new vikingEntities();
        public List<T> getAll()
        {
            return db.Set<T>().ToList();
        }

        public void add(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public void delete(int id)
        {
            var item = db.Set<T>().Find(id);
            if (item != null)
            {
                db.Set<T>().Remove(item);
                db.SaveChanges();
            }
        }

        public void update(T entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
