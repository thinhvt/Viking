using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viking.Data.Models.Entities.Repositories;

namespace Viking.Data.Models.Entities.Services
{
    public interface ICampaignService
    {
        List<tbl_Campain> getAllCampaign();
        void add(tbl_Campain item);
        void delete(int id);
        void update(tbl_Campain item);
    }
    public class CampaignService : ICampaignService
    {
        CampaignRepository rep = new CampaignRepository();

        public List<tbl_Campain> getAllCampaign()
        {
            return rep.getAll();
        }
        public void add(tbl_Campain item)
        {
            rep.add(item);
        }

        public void delete(int id)
        {
            rep.delete(id);
        }

        public void update(tbl_Campain item)
        {
            rep.update(item);
        }
    }
}
