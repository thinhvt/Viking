//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversityManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class University
    {
        public University()
        {
            this.Classes = new HashSet<Class>();
        }
    
        public int ID { get; set; }
        public string UniName { get; set; }
        public string Phone { get; set; }
        public string Addr { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<Class> Classes { get; set; }
    }
}