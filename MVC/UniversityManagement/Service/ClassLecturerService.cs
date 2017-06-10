using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Repository;

namespace UniversityManagement.Service
{
    public class ClassLecturerService
    {
        ClassLecturerRepository repo = new ClassLecturerRepository();

        public List<Class_Lecturer> getAll()
        {
            return repo.getAll();
        }

        public Class_Lecturer FindByID(int id)
        {
            return repo.findByID(id);
        }

        public void add(Class_Lecturer T)
        {
            repo.add(T);
        }

        public void update(Class_Lecturer T)
        {
            repo.update(T);
        }

        public void delete(int id)
        {
            repo.delete(id);
        }
    }
}
