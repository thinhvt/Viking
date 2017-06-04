using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viking.Data.Models.ViewModels
{
    public class AccountViewModel
    {
        public string accountId { get; set; }
        public string teamID { get; set; }
        public string accountPass { get; set; }
        public string accountName { get; set; }
        public string aPhone { get; set; }
        public string aFBurl { get; set; }
        public string aAddress { get; set; }
        public string aCMND { get; set; }
        public Nullable<int> aRoleId { get; set; }
        public string aEmail { get; set; }
        public Nullable<bool> aIsMale { get; set; }
    }
}
