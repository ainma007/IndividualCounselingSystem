using IndividualCounseling.Models.Foreignkey;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace IndividualCounseling.Models.Cases
{
    public class CasesService
    {

        private IndividualCounselingEntities entities;
        public CasesService(IndividualCounselingEntities entities)
        {
            this.entities = entities;
        }

        public IEnumerable<CasesViewModel> Read()
        {
            return entities.Case_Table
                        .Select(db => new CasesViewModel
                        {
                            CasesID = db.CasesID,
                            CasesNumber = db.CasesNumber,
                            CasesDate = db.CasesDate.HasValue ? db.CasesDate.Value : default(DateTime),
                            CasesStatus = db.CasesStatus,
                            CasesName = db.CasesName,
                            CasesGender = db.CasesGender,
                            CasesAge = db.CasesAge,
                            CasesCitizen = db.CasesCitizen,
                            StudyFather = db.StudyFather,
                            StudyMother = db.StudyMother,
                            FatherWork = db.FatherWork,
                            MotherWork = db.MotherWork,
                            ParentalStatus = db.ParentalStatus,
                            ParentsRelationship = db.ParentsRelationship,
                            EconomicLevel = db.EconomicLevel,
                            CasesMobile = db.CasesMobile,
                            BrothersNumber = db.BrothersNumber,
                            MaleNumber = db.MaleNumber,
                            FemalNumber = db.FemalNumber,
                            CasesSorted = db.CasesSorted,
                            Childlives = db.Childlives,
                            ChildLivesWith = db.ChildLivesWith,
                            GovernorateID=db.GovernorateID,
                                                                               
                            Governorate = new GovernorateViewModel()
                            {
                                GovernorateID = db.Governorate_Table.GovernorateID,
                                GovernorateName = db.Governorate_Table.GovernorateArName,
                            },
                            AreaID=db.AreaID,
                            Area = new AreaViewModel()
                            {
                                AreaID = db.Area_Table.AreaID,
                                AreaName = db.Area_Table.AreaArName
                            },

                            AreasRating = db.AreasRating,
                            CasesAdress = db.CasesAdress,
                            ChildStudy = db.ChildStudy,
                            EducationalLevel = db.EducationalLevel,
                            SchoolType = db.SchoolType,
                            SchoolName = db.SchoolName,
                            CasesAssault = db.CasesAssault,
                            KnownAssailant = db.KnownAssailant,
                            AssailantName = db.AssailantName,
                            AssailanKinship = db.AssailanKinship,
                            AssailanGender = db.AssailanGender,
                            AssaultPhysical = db.AssaultPhysical,
                            AssaultSexual = db.AssaultSexual,
                            AssaultVerbal = db.AssaultVerbal,
                            AssaultNeglecting = db.AssaultNeglecting,
                            AssaultSpy = db.AssaultSpy,
                            AssaultExploit = db.AssaultExploit,
                            AssaultKidnapping = db.AssaultKidnapping,
                            AssaultDate = db.AssaultDate.HasValue ? db.AssaultDate.Value : default(DateTime),
                            AssaultPlace = db.AssaultPlace,
                            AssaultReport = db.AssaultReport,
                            AssaultRepeatAttack = db.AssaultRepeatAttack,
                            AssaultLevePain = db.AssaultLevePain,
                            ChildConvertingFoundation = db.ChildConvertingFoundation,
                            CenterName = db.CenterName,
                            Effects_break = db.Effects_break,
                            Effects_Wounds = db.Effects_Wounds,
                            Effects_Bruising = db.Effects_Bruising,
                            Effects_Distortion = db.Effects_Distortion,
                            Effects_Burns = db.Effects_Burns,
                            intimation_Parents = db.intimation_Parents,
                            intimation_Police = db.intimation_Police,
                            intimation_Corporation = db.intimation_Corporation,
                            intimation_School = db.intimation_School,
                            intimation_Friend = db.intimation_Friend,
                            IncidentDescription = db.IncidentDescription,
                            undesirable_Behavior = db.undesirable_Behavior,
                            RepeatBehavior = db.RepeatBehavior,
                            foreman_For_behavior = db.foreman_For_behavior,
                            TimeBehavior = db.TimeBehavior,
                            Disorder_Behavioural = db.Disorder_Behavioural,
                            Disorder_Psychological = db.Disorder_Psychological,
                            Disorder_Learn = db.Disorder_Learn,
                            Disorder_Pronounce = db.Disorder_Pronounce,
                            Disorder_Urination = db.Disorder_Urination,
                            Disorder_Sleep = db.Disorder_Sleep,
                            Disorder_PositionsShocking = db.Disorder_PositionsShocking,
                            Disorder_Maltreatment = db.Disorder_Maltreatment,
                            Disorder_SexualHarassment = db.Disorder_SexualHarassment,
                            Disorder_rape = db.Disorder_rape,
                            Disorder_Resuscitatesexual=db.Disorder_Resuscitatesexual,
                            Recommendations = db.Recommendations,

                            UserID=db.UserID,
                            ProID=db.ProjectID,
                        });
        }
        public void Create(CasesViewModel db)
        {
            var entity = new Case_Table();
            entity.CasesNumber = db.CasesNumber;
            entity.CasesDate = (DateTime)db.CasesDate.Date;

            entity.CasesStatus = db.CasesStatus;
            entity.CasesName = db.CasesName;
            entity.CasesGender = db.CasesGender;
            entity.CasesAge = db.CasesAge;
            entity.CasesCitizen = db.CasesCitizen;
            entity.StudyFather = db.StudyFather;
            entity.StudyMother = db.StudyMother;
            entity.FatherWork = db.FatherWork;
            entity.MotherWork = db.MotherWork;
            entity.ParentalStatus = db.ParentalStatus;
            entity.ParentsRelationship = db.ParentsRelationship;
            entity.EconomicLevel = db.EconomicLevel;
            entity.CasesMobile = db.CasesMobile;
            entity.BrothersNumber = db.BrothersNumber;
            entity.MaleNumber = db.MaleNumber;
            entity.FemalNumber = db.FemalNumber;
            entity.CasesSorted = db.CasesSorted;
            entity.Childlives = db.Childlives;

            entity.ChildLivesWith = db.ChildLivesWith;
            entity.GovernorateID = db.GovernorateID;
            entity.AreaID = db.AreaID;
            entity.AreasRating = db.AreasRating;
            entity.CasesAdress = db.CasesAdress;
            entity.ChildStudy = db.ChildStudy;
            entity.EducationalLevel = db.EducationalLevel;
            entity.SchoolType = db.SchoolType;
            entity.SchoolName = db.SchoolName;
            entity.CasesAssault = db.CasesAssault;
            entity.KnownAssailant = db.KnownAssailant;
            entity.AssailantName = db.AssailantName;
            entity.AssailanKinship = db.AssailanKinship;
            entity.AssailanGender = db.AssailanGender;
            entity.AssaultPhysical = db.AssaultPhysical;
            entity.AssaultSexual = db.AssaultSexual;
            entity.AssaultVerbal = db.AssaultVerbal;
            entity.AssaultNeglecting = db.AssaultNeglecting;
            entity.AssaultSpy = db.AssaultSpy;
            entity.AssaultExploit = db.AssaultExploit;
            entity.AssaultKidnapping = db.AssaultKidnapping;
            entity.AssaultDate = db.AssaultDate;
            entity.AssaultPlace = db.AssaultPlace;
            entity.AssaultReport = db.AssaultReport;
            entity.AssaultRepeatAttack = db.AssaultRepeatAttack;
            entity.AssaultLevePain = db.AssaultLevePain;
            entity.ChildConvertingFoundation = db.ChildConvertingFoundation;
            entity.CenterName = db.CenterName;
            entity.Effects_break = db.Effects_break;
            entity.Effects_Wounds = db.Effects_Wounds;
            entity.Effects_Bruising = db.Effects_Bruising;
            entity.Effects_Distortion = db.Effects_Distortion;
            entity.Effects_Burns = db.Effects_Burns;
            entity.intimation_Parents = db.intimation_Parents;
            entity.intimation_Police = db.intimation_Police;
            entity.intimation_Corporation = db.intimation_Corporation;
            entity.intimation_School = db.intimation_School;
            entity.intimation_Friend = db.intimation_Friend;
            entity.IncidentDescription = HttpUtility.HtmlDecode(db.IncidentDescription);
            entity.undesirable_Behavior = db.undesirable_Behavior;
            entity.RepeatBehavior = db.RepeatBehavior;
            entity.foreman_For_behavior = db.foreman_For_behavior;
            entity.TimeBehavior = db.TimeBehavior;
            entity.Disorder_Behavioural = db.Disorder_Behavioural;
            entity.Disorder_Psychological = db.Disorder_Psychological;
            entity.Disorder_Learn = db.Disorder_Learn;
            entity.Disorder_Pronounce = db.Disorder_Pronounce;
            entity.Disorder_Urination = db.Disorder_Urination;
            entity.Disorder_Sleep = db.Disorder_Sleep;
            entity.Disorder_PositionsShocking = db.Disorder_PositionsShocking;
            entity.Disorder_Maltreatment = db.Disorder_Maltreatment;
            entity.Disorder_SexualHarassment = db.Disorder_SexualHarassment;
            entity.Disorder_rape = db.Disorder_rape;
            entity.Disorder_Resuscitatesexual = db.Disorder_Resuscitatesexual;
            entity.Recommendations = HttpUtility.HtmlDecode(db.Recommendations);
            entity.ProjectID = db.ProID;
            entity.UserID = db.UserID;
                      
            entities.Case_Table.Add(entity);
            entities.SaveChanges();

            db.CasesID = entity.CasesID;
        }
        public void Update(CasesViewModel db)
        {
            var entity = new Case_Table();
            entity.CasesID = db.CasesID;
            entity.CasesNumber = db.CasesNumber;
            entity.CasesDate = (DateTime)db.CasesDate.Date;

            entity.CasesStatus = db.CasesStatus;
            entity.CasesName = db.CasesName;
            entity.CasesGender = db.CasesGender;
            entity.CasesAge = db.CasesAge;
            entity.CasesCitizen = db.CasesCitizen;
            entity.StudyFather = db.StudyFather;
            entity.StudyMother = db.StudyMother;
            entity.FatherWork = db.FatherWork;
            entity.MotherWork = db.MotherWork;
            entity.ParentalStatus = db.ParentalStatus;
            entity.ParentsRelationship = db.ParentsRelationship;
            entity.EconomicLevel = db.EconomicLevel;
            entity.CasesMobile = db.CasesMobile;
            entity.BrothersNumber = db.BrothersNumber;
            entity.MaleNumber = db.MaleNumber;
            entity.FemalNumber = db.FemalNumber;
            entity.CasesSorted = db.CasesSorted;
            entity.Childlives = db.Childlives;

            entity.ChildLivesWith = db.ChildLivesWith;
            entity.GovernorateID = db.GovernorateID;
            entity.AreaID = db.AreaID;
            entity.AreasRating = db.AreasRating;
            entity.CasesAdress = db.CasesAdress;
            entity.ChildStudy = db.ChildStudy;
            entity.EducationalLevel = db.EducationalLevel;
            entity.SchoolType = db.SchoolType;
            entity.SchoolName = db.SchoolName;
            entity.CasesAssault = db.CasesAssault;
            entity.KnownAssailant = db.KnownAssailant;
            entity.AssailantName = db.AssailantName;
            entity.AssailanKinship = db.AssailanKinship;
            entity.AssailanGender = db.AssailanGender;
            entity.AssaultPhysical = db.AssaultPhysical;
            entity.AssaultSexual = db.AssaultSexual;
            entity.AssaultVerbal = db.AssaultVerbal;
            entity.AssaultNeglecting = db.AssaultNeglecting;
            entity.AssaultSpy = db.AssaultSpy;
            entity.AssaultExploit = db.AssaultExploit;
            entity.AssaultKidnapping = db.AssaultKidnapping;
            entity.AssaultDate = db.AssaultDate;
            entity.AssaultPlace = db.AssaultPlace;
            entity.AssaultReport = db.AssaultReport;
            entity.AssaultRepeatAttack = db.AssaultRepeatAttack;
            entity.AssaultLevePain = db.AssaultLevePain;
            entity.ChildConvertingFoundation = db.ChildConvertingFoundation;
            entity.CenterName = db.CenterName;
            entity.Effects_break = db.Effects_break;
            entity.Effects_Wounds = db.Effects_Wounds;
            entity.Effects_Bruising = db.Effects_Bruising;
            entity.Effects_Distortion = db.Effects_Distortion;
            entity.Effects_Burns = db.Effects_Burns;
            entity.intimation_Parents = db.intimation_Parents;
            entity.intimation_Police = db.intimation_Police;
            entity.intimation_Corporation = db.intimation_Corporation;
            entity.intimation_School = db.intimation_School;
            entity.intimation_Friend = db.intimation_Friend;
            entity.IncidentDescription = HttpUtility.HtmlDecode(db.IncidentDescription);
            entity.undesirable_Behavior = db.undesirable_Behavior;
            entity.RepeatBehavior = db.RepeatBehavior;
            entity.foreman_For_behavior = db.foreman_For_behavior;
            entity.TimeBehavior = db.TimeBehavior;
            entity.Disorder_Behavioural = db.Disorder_Behavioural;
            entity.Disorder_Psychological = db.Disorder_Psychological;
            entity.Disorder_Learn = db.Disorder_Learn;
            entity.Disorder_Pronounce = db.Disorder_Pronounce;
            entity.Disorder_Urination = db.Disorder_Urination;
            entity.Disorder_Sleep = db.Disorder_Sleep;
            entity.Disorder_PositionsShocking = db.Disorder_PositionsShocking;
            entity.Disorder_Maltreatment = db.Disorder_Maltreatment;
            entity.Disorder_SexualHarassment = db.Disorder_SexualHarassment;
            entity.Disorder_rape = db.Disorder_rape;
            entity.Disorder_Resuscitatesexual = db.Disorder_Resuscitatesexual;
            entity.Recommendations = HttpUtility.HtmlDecode(db.Recommendations);
            entity.ProjectID = db.ProID;
            entity.UserID = db.UserID;
            entities.Case_Table.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }
        public void Destroy(CasesViewModel db)
        {
            var entity = new Case_Table();

            entity.CasesID = db.CasesID;

            entities.Case_Table.Attach(entity);

            entities.Case_Table.Remove(entity);

            entities.SaveChanges();
        }

        public IEnumerable<GovernorateViewModel> ReadGovernorate()
        {
            return entities.Governorate_Table.Select(province => new GovernorateViewModel
            {
                GovernorateID = province.GovernorateID,
                GovernorateName = province.GovernorateArName


            });
        }

        public IEnumerable<AreaViewModel> ReadArea(int governorateID)
        {
            return entities.Area_Table.Where(m => m.GovernorateID == governorateID).Select(province => new AreaViewModel
            {
                AreaID = province.AreaID,
                AreaName = province.AreaArName


            });
        }



        public void Dispose()
        {
            entities.Dispose();
        }
    }
}