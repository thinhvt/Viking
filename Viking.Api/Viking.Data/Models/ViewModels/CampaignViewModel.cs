using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viking.Data.Models.ViewModels
{
    public class CampaignViewModel
    {
        public int campainId { get; set; }
        public string campainCode { get; set; }
        public string campDes { get; set; }
        public Nullable<System.DateTime> dateStart { get; set; }
        public Nullable<System.DateTime> dateEnd { get; set; }
    }
}
