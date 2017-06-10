using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Repository;

namespace UniversityManagement.Service
{
    public class StudentService
    {
        StudentRepository repo = new StudentRepository();

        public List<Student> getAll()
        {
            return repo.getAll();
        }

        public Student FindByID(int id)
        {
            return repo.findByID(id);
        }

        public void add(Student T)
        {
            repo.add(T);
        }

        public void update(Student T)
        {
            repo.update(T);
        }

        public void delete(int id)
        {
            repo.delete(id);
        }
    }
}
