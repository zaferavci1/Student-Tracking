//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentTracking
{
    using System;
    using System.Collections.Generic;
    
    public partial class program
    {
        public program()
        {
            this.groups = new HashSet<groups>();
        }
    
        public int id { get; set; }
        public Nullable<int> semester_id { get; set; }
        public Nullable<int> course_id { get; set; }
        public Nullable<int> teacher_id { get; set; }
    
        public virtual courses courses { get; set; }
        public virtual ICollection<groups> groups { get; set; }
        public virtual semesters semesters { get; set; }
        public virtual teachers teachers { get; set; }
    }
}