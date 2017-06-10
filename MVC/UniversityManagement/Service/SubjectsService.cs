using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Repository;

namespace UniversityManagement.Service
{
    public class SubjectsService
    {
        SubjectsRepository repo = new SubjectsRepository();

        public List<Subject> getAll()
        {
            return repo.getAll();
        }

        public Subject FindByID(int id)
        {
            return repo.findByID(id);
        }

        public void add(Subject T)
        {
            repo.add(T);
        }

        public void update(Subject T)
        {
            repo.update(T);
        }

        public void delete(int id)
        {
            repo.delete(id);
        }
    }
}
