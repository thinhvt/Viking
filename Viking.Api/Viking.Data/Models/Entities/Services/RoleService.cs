using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viking.Data.Models.Entities.Repositories;

namespace Viking.Data.Models.Entities.Services
{
    public interface IRoleService
    {
        List<tbl_Role> getAllRoles();
        void add(tbl_Role item);
        void delete(int id);
        void update(tbl_Role item);
    }
    class RoleService
    {
        RoleRepository rep = new RoleRepository();

        public List<tbl_Role> getAllRoles()
        {
            return rep.getAll();
        }
        public void add(tbl_Role item)
        {
            rep.add(item);
        }

        public void delete(int id)
        {
            rep.delete(id);
        }

        public void update(tbl_Role item)
        {
            rep.update(item);
        }
    }
}
