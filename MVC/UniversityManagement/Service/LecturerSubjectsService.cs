using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Repository;

namespace UniversityManagement.Service
{
    public class LecturerSubjectsService
    {
        LecturerSubjectsRepository repo = new LecturerSubjectsRepository();

        public List<Lecturer_Subjects> getAll()
        {
            return repo.getAll();
        }

        public Lecturer_Subjects FindByID(int id)
        {
            return repo.findByID(id);
        }

        public void add(Lecturer_Subjects T)
        {
            repo.add(T);
        }

        public void update(Lecturer_Subjects T)
        {
            repo.update(T);
        }

        public void delete(int id)
        {
            repo.delete(id);
        }
    }
}
