using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Repository;

namespace UniversityManagement.Service
{
    public class StudentSubjectsService
    {
        StudentSubjectsRepository repo = new StudentSubjectsRepository();

        public List<Student_Subjects> getAll()
        {
            return repo.getAll();
        }

        public Student_Subjects FindByID(int id)
        {
            return repo.findByID(id);
        }

        public void add(Student_Subjects T)
        {
            repo.add(T);
        }

        public void update(Student_Subjects T)
        {
            repo.update(T);
        }

        public void delete(int id)
        {
            repo.delete(id);
        }
    }
}
