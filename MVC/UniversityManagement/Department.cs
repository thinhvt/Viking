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
    
    public partial class Department
    {
        public Department()
        {
            this.Lecturers = new HashSet<Lecturer>();
            this.Subjects = new HashSet<Subject>();
        }
    
        public int ID { get; set; }
        public string DepName { get; set; }
        public string ManagerCode { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
    
        public virtual ICollection<Lecturer> Lecturers { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
