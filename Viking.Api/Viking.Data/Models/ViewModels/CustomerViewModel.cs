using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viking.Data.Models.Entities;

namespace Viking.Data.Models.ViewModels
{
    public class CustomerViewModel
    {
        public CustomerViewModel(tbl_Customer customer, int? stageID)
        {
            CusId = customer.CusId;
            CusCMND = customer.CusCMND;
            CusName = customer.CusName;
            CusPhone = customer.CusPhone;
            CusAddress = customer.CusAddress;
            CusCompany = customer.CusCompany;
            CusPosition = customer.CusPosition;
            CusSalary = customer?.CusSalary;
            CusNote = customer.CusNote;
            CusEmail = customer.CusEmail;
            CusSexIsMale = customer?.CusSexIsMale;
            CusDateOfBirth = customer?.CusDateOfBirth;
            CusCICNumber = customer.CusCICNumber;
            CusLimitOffer = customer?.CusLimitOffer;
            CusDistrict = customer.CusDistrict;
            CusCity = customer.CusCity;
            CusLeadProDuct = customer.CusLeadProDuct;
            CusVPID = customer.CusVPID;
            Branches = customer.Branches;
            stageId = stageID;
        }

        public int CusId { get; set; }
        public string CusCMND { get; set; }
        public string CusName { get; set; }
        public string CusPhone { get; set; }
        public string CusAddress { get; set; }
        public string CusCompany { get; set; }
        public string CusPosition { get; set; }
        public Nullable<double> CusSalary { get; set; }
        public string CusNote { get; set; }
        public string CusEmail { get; set; }
        public Nullable<bool> CusSexIsMale { get; set; }
        public Nullable<System.DateTime> CusDateOfBirth { get; set; }
        public string CusCICNumber { get; set; }
        public Nullable<double> CusLimitOffer { get; set; }
        public string CusDistrict { get; set; }
        public string CusCity { get; set; }
        public string CusLeadProDuct { get; set; }
        public string CusVPID { get; set; }
        public string Branches { get; set; }
        public Nullable<int> stageId { get; set; }
    }
}
