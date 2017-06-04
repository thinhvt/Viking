using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viking.Data.Models.Entities.Repositories;

namespace Viking.Data.Models.Entities.Services
{
    public interface IKPIService
    {
        List<tbl_KPI> getAllKPIs();
        void add(tbl_KPI item);
        void delete(int id);
        void update(tbl_KPI item);
    }
    public class KPIService
    {
        KPIRepository rep = new KPIRepository();

        public List<tbl_KPI> getAllKPIs()
        {
            return rep.getAll();
        }
        public void add(tbl_KPI item)
        {
            rep.add(item);
        }

        public void delete(int id)
        {
            rep.delete(id);
        }

        public void update(tbl_KPI item)
        {
            rep.update(item);
        }
    }
}
