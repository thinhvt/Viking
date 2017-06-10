using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Repository;

namespace UniversityManagement.Service
{
    public class UniversityService
    {
        UniversityRepository repo = new UniversityRepository();

        public List<University> getAll()
        {
            return repo.getAll();
        }

        public University FindByID(int id)
        {
            return repo.findByID(id);
        }

        public void add(University T)
        {
            repo.add(T);
        }

        public void update(University T)
        {
            repo.update(T);
        }

        public void delete(int id)
        {
            repo.delete(id);
        }
    }
}
