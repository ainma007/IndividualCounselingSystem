//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IndividualCounseling.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectTable
    {
        public ProjectTable()
        {
            this.Case_Table = new HashSet<Case_Table>();
            this.ProjectControl_Table = new HashSet<ProjectControl_Table>();
        }
    
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    
        public virtual ICollection<Case_Table> Case_Table { get; set; }
        public virtual ICollection<ProjectControl_Table> ProjectControl_Table { get; set; }
    }
}
