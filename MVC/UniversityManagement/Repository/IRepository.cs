using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.Repository
{
    interface IRepository<T> where T : class
    {
        List<T> getAll();
        T findByID(int id);
        void add(T entity);
        void update(T entity);
        void delete(int id);
    }
}
