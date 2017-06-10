using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagement.View_Model
{
    public class DepartmentViewModel
    {
        public int ID { get; set; }
        public string DepName { get; set; }
        public string ManagerCode { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
    }
}
