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
    
    public partial class Lecturer
    {
        public Lecturer()
        {
            this.Class_Lecturer = new HashSet<Class_Lecturer>();
            this.Lecturer_Subjects = new HashSet<Lecturer_Subjects>();
        }
    
        public int ID { get; set; }
        public string LecCode { get; set; }
        public string LecName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Addr { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public int DepartmentID { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual ICollection<Class_Lecturer> Class_Lecturer { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Lecturer_Subjects> Lecturer_Subjects { get; set; }
    }
}