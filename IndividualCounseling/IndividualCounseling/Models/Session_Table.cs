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
    
    public partial class Session_Table
    {
        public int sessionID { get; set; }
        public Nullable<System.DateTime> sessionDate { get; set; }
        public string sessionResult { get; set; }
        public string sessionRecommendations { get; set; }
        public Nullable<int> CaseID { get; set; }
    
        public virtual Case_Table Case_Table { get; set; }
    }
}
