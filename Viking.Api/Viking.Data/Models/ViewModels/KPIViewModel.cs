using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viking.Data.Models.ViewModels
{
    public class KPIViewModel
    {
        public int kpiID { get; set; }
        public Nullable<int> roleID { get; set; }
        public Nullable<int> kpiNumber { get; set; }
    }
}
