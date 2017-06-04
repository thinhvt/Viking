using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viking.Data.Models.Entities.Repositories;

namespace Viking.Data.Models.Entities.Services
{
    public interface IStageService
    {
        List<tbl_Stage> getAllStage();
        void add(tbl_Stage item);
        void delete(int id);
        void update(tbl_Stage item);
    }
    public class StageService
    {
        StageRepository rep = new StageRepository();

        public List<tbl_Stage> getAllStage()
        {
            return rep.getAll();
        }
        public void add(tbl_Stage item)
        {
            rep.add(item);
        }

        public void delete(int id)
        {
            rep.delete(id);
        }

        public void update(tbl_Stage item)
        {
            rep.update(item);
        }
    }
}
