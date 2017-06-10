using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.Repository
{
    class BaseRepository<T> : IRepository<T> where T : class
    {
        public List<T> getAll()
        {
            using (var db = new UniversityEntities())
            {
                return db.Set<T>().ToList();
            }
        }

        public T findByID(int id)
        {
            using (var db = new UniversityEntities())
            {
                return db.Set<T>().Find(id);
            }
        }

        public void add(T entity)
        {
            using (var db = new UniversityEntities())
            {
                db.Set<T>().Add(entity);
                db.SaveChanges();
            }
        }

        public void update(T entity)
        {
            using (var db = new UniversityEntities())
            {
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (var db = new UniversityEntities())
            {
                var item = db.Set<T>().Find(id);
                db.Set<T>().Remove(item);
                db.SaveChanges();
            }
        }
    }
}
