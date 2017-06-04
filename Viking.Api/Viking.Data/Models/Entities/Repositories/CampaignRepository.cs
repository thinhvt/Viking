using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viking.Data.Models.Entities.Repositories
{
    interface ICampaignRepository
    {

    }
    class CampaignRepository : BaseRepository<tbl_Campain>, ICampaignRepository
    {
    }
}
