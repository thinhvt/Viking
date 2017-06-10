using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Repository;

namespace UniversityManagement.Service
{
    public class ClassService
    {
        ClassRepository repo = new ClassRepository();

        public List<Class> getAll()
        {
            return repo.getAll();
        }

        public Class FindByID(int id)
        {
            return repo.findByID(id);
        }

        public void add(Class T)
        {
            repo.add(T);
        }

        public void update(Class T)
        {
            repo.update(T);
        }

        public void delete(int id)
        {
            repo.delete(id);
        }
    }
}
