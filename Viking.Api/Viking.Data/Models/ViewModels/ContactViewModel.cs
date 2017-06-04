using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viking.Data.Models.ViewModels
{
    public class ContactViewModel
    {
        public int id { get; set; }
        public Nullable<System.DateTime> dateStart { get; set; }
        public Nullable<System.DateTime> dateEnd { get; set; }
        public Nullable<System.DateTime> lastUpdate { get; set; }
        public string note { get; set; }
        public Nullable<int> cusID { get; set; }
        public string curAdminId { get; set; }
        public string teamID { get; set; }
        public Nullable<int> proID { get; set; }
        public Nullable<double> loanAmounth { get; set; }
        public Nullable<int> stageID { get; set; }
        public string history { get; set; }
        public string referenceSource { get; set; }
        public Nullable<int> campainID { get; set; }
    }
}
