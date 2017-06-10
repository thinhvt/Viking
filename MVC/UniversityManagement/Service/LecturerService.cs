using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Repository;

namespace UniversityManagement.Service
{
    public class LecturerService
    {
        LecturerRepository repo = new LecturerRepository();

        public List<Lecturer> getAll()
        {
            return repo.getAll();
        }

        public Lecturer FindByID(int id)
        {
            return repo.findByID(id);
        }

        public void add(Lecturer T)
        {
            repo.add(T);
        }

        public void update(Lecturer T)
        {
            repo.update(T);
        }

        public void delete(int id)
        {
            repo.delete(id);
        }
    }
}
