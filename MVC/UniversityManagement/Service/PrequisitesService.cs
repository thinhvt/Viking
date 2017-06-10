using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Repository;

namespace UniversityManagement.Service
{
    public class PrequisitesService
    {
        PrequisitesRepository repo = new PrequisitesRepository();

        public List<Prequisite> getAll()
        {
            return repo.getAll();
        }

        public Prequisite FindByID(int id)
        {
            return repo.findByID(id);
        }

        public void add(Prequisite T)
        {
            repo.add(T);
        }

        public void update(Prequisite T)
        {
            repo.update(T);
        }

        public void delete(int id)
        {
            repo.delete(id);
        }
    }
}
