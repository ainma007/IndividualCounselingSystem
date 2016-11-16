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
    
    public partial class Case_Table
    {
        public Case_Table()
        {
            this.Session_Table = new HashSet<Session_Table>();
        }
    
        public int CasesID { get; set; }
        public string CasesNumber { get; set; }
        public Nullable<System.DateTime> CasesDate { get; set; }
        public string CasesStatus { get; set; }
        public string CasesName { get; set; }
        public string CasesGender { get; set; }
        public Nullable<int> CasesAge { get; set; }
        public string CasesCitizen { get; set; }
        public string StudyFather { get; set; }
        public string StudyMother { get; set; }
        public string FatherWork { get; set; }
        public string MotherWork { get; set; }
        public string ParentalStatus { get; set; }
        public string ParentsRelationship { get; set; }
        public string EconomicLevel { get; set; }
        public string CasesMobile { get; set; }
        public Nullable<int> BrothersNumber { get; set; }
        public Nullable<int> MaleNumber { get; set; }
        public Nullable<int> FemalNumber { get; set; }
        public Nullable<int> CasesSorted { get; set; }
        public string Childlives { get; set; }
        public string ChildLivesWith { get; set; }
        public Nullable<int> GovernorateID { get; set; }
        public Nullable<int> AreaID { get; set; }
        public string AreasRating { get; set; }
        public string CasesAdress { get; set; }
        public string ChildStudy { get; set; }
        public string EducationalLevel { get; set; }
        public string SchoolType { get; set; }
        public string SchoolName { get; set; }
        public string CasesAssault { get; set; }
        public string KnownAssailant { get; set; }
        public string AssailantName { get; set; }
        public string AssailanKinship { get; set; }
        public string AssailanGender { get; set; }
        public bool AssaultPhysical { get; set; }
        public bool AssaultSexual { get; set; }
        public bool AssaultVerbal { get; set; }
        public bool AssaultNeglecting { get; set; }
        public bool AssaultSpy { get; set; }
        public bool AssaultExploit { get; set; }
        public bool AssaultKidnapping { get; set; }
        public Nullable<System.DateTime> AssaultDate { get; set; }
        public string AssaultPlace { get; set; }
        public string AssaultReport { get; set; }
        public string AssaultRepeatAttack { get; set; }
        public string AssaultLevePain { get; set; }
        public string ChildConvertingFoundation { get; set; }
        public string CenterName { get; set; }
        public bool Effects_break { get; set; }
        public bool Effects_Wounds { get; set; }
        public bool Effects_Bruising { get; set; }
        public bool Effects_Distortion { get; set; }
        public bool Effects_Burns { get; set; }
        public bool intimation_Parents { get; set; }
        public bool intimation_Police { get; set; }
        public bool intimation_Corporation { get; set; }
        public bool intimation_School { get; set; }
        public bool intimation_Friend { get; set; }
        public string IncidentDescription { get; set; }
        public string undesirable_Behavior { get; set; }
        public string RepeatBehavior { get; set; }
        public string foreman_For_behavior { get; set; }
        public string TimeBehavior { get; set; }
        public bool Disorder_Behavioural { get; set; }
        public bool Disorder_Psychological { get; set; }
        public bool Disorder_Learn { get; set; }
        public bool Disorder_Pronounce { get; set; }
        public bool Disorder_Urination { get; set; }
        public bool Disorder_Sleep { get; set; }
        public bool Disorder_PositionsShocking { get; set; }
        public bool Disorder_Maltreatment { get; set; }
        public bool Disorder_SexualHarassment { get; set; }
        public bool Disorder_rape { get; set; }
        public bool Disorder_Resuscitatesexual { get; set; }
        public string Recommendations { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Area_Table Area_Table { get; set; }
        public virtual Governorate_Table Governorate_Table { get; set; }
        public virtual ProjectTable ProjectTable { get; set; }
        public virtual Users_Table Users_Table { get; set; }
        public virtual ICollection<Session_Table> Session_Table { get; set; }
    }
}