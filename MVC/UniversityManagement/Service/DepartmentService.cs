using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Repository;

namespace UniversityManagement.Service
{
    public class DepartmentService
    {
        DepartmentRepository repo = new DepartmentRepository();

        public List<Department> getAll()
        {
            return repo.getAll();
        }

        public Department FindByID(int id)
        {
            return repo.findByID(id);
        }

        public void add(Department T)
        {
            repo.add(T);
        }

        public void update(Department T)
        {
            repo.update(T);
        }

        public void delete(int id)
        {
            repo.delete(id);
        }
    }
}
