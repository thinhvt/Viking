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
    
    public partial class Student
    {
        public Student()
        {
            this.Student_Subjects = new HashSet<Student_Subjects>();
        }
    
        public int ID { get; set; }
        public string StudentCode { get; set; }
        public string StudentName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Addr { get; set; }
        public string Sex { get; set; }
        public int ClassID { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual ICollection<Student_Subjects> Student_Subjects { get; set; }
    }
}
