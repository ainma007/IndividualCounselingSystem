using IndividualCounseling.Models.Foreignkey;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndividualCounseling.Models.Cases
{
    public class CasesViewModel
    {
        public int CasesID { get; set; }
        public int? UserID { get; set; }
        public int? ProID { get; set; }


        [DisplayName("تاريخ الحالة:")]
        public string CasesNumber { get; set; }

        [DisplayName("تاريخ الحالة:")]
        [DataType(DataType.Date)]
        public DateTime CasesDate { get; set; }

        [DisplayName("وضع الحالة:")]
        public string CasesStatus { get; set; }


        [DisplayName("اسم الحالة رباعي:")]
        public string CasesName { get; set; }

        [DisplayName("الجنس:")]
       
        public string CasesGender { get; set; }

        [DisplayName("العمر:")]

        [Required(ErrorMessage = "من فضلك ادخل العمر .")]
        [Column]
        public int? CasesAge { get; set; }


        [DisplayName("الحالة:")]
        public string CasesCitizen { get; set; }

        [DisplayName("المستوى الدراسي للاب :")]
        public string  StudyFather { get; set; }

        [DisplayName("المستوى الدراسي للام :")]
        public string StudyMother { get; set; }

        [DisplayName("مهنة الأب :")]
        public string FatherWork { get; set; }

        [DisplayName("مهنة الام :")]
        public string MotherWork { get; set; }

        [DisplayName("حالة الوالدين :")]
        public string ParentalStatus { get; set; }

        [DisplayName("العلاقة بين الوالدين :")]
        public string ParentsRelationship { get; set; }


        [DisplayName("االمستوى الاقتصادي :")]
        public string EconomicLevel { get; set; }

        [DisplayName("رقم الهاتف/الجوال :")]
        public string CasesMobile { get; set; }

        [DisplayName("عدد الأخوة :")]
        public int? BrothersNumber { get; set; }

        [DisplayName("عدد الذكور :")]
        public int? MaleNumber { get; set; }

        [DisplayName("عدد الاناث :")]
        public int? FemalNumber { get; set; }

        [DisplayName("ترتيبه بين الاخوة :")]
        public int? CasesSorted { get; set; }

        [DisplayName("يعيش الطفل مع :")]
        public string Childlives { get; set; }

        [DisplayName("يسكن الطفل مع :")]
        public string ChildLivesWith { get; set; }

        [UIHint("ClientGovernorate")]
        public GovernorateViewModel Governorate
        {
            get;
            set;
        }

        [UIHint("GovernorateID")]
        [DisplayName("المحافظة :")]
        public int? GovernorateID { get; set; }

        [UIHint("ClientArea")]
        public AreaViewModel Area
        {
            get;
            set;
        }

        [UIHint("AreaID")]
        [DisplayName("المنطقة :")]
        public int? AreaID { get; set; }


        [DisplayName("تصنيف المنطقة :")]
        public string AreasRating { get; set; }


        [DisplayName("العنوان :")]
        public string CasesAdress { get; set; }

        [DisplayName("الطفل ملتحق بمدرسة :")]
        public string ChildStudy { get; set; }

        [DisplayName("المرحلة التعليمية :")]
        public string EducationalLevel { get; set; }

        [DisplayName("نوع المدرسة :")]
        public string SchoolType { get; set; }

        [DisplayName("اسم المدرسة :")]
        public string SchoolName { get; set; }

        [DisplayName("هل هناك اعتداء :")]
        public string CasesAssault { get; set; }

        [DisplayName("هل المعتدي معروف :")]
        public string KnownAssailant { get; set; }


        [DisplayName("اسم المعتدي :")]
        public string AssailantName { get; set; }

        [DisplayName("صلة القرابة :")]
        public string AssailanKinship { get; set; }


        [DisplayName("جنس المعتدى :")]
        public string AssailanGender { get; set; }

        [DisplayName("جسدي")]
        public bool AssaultPhysical { get; set; }
        [DisplayName("جنسي")]
        public bool AssaultSexual { get; set; }

        [DisplayName("لفظي")]
        public bool AssaultVerbal { get; set; }

        [DisplayName("اهمال")]
        public bool AssaultNeglecting { get; set; }

        [DisplayName("عمالة اطفال")]
        public bool AssaultSpy { get; set; }

        [DisplayName("استغلال")]
        public bool AssaultExploit { get; set; }

        [DisplayName("اختطاف")]
        public bool AssaultKidnapping { get; set; }


        [DisplayName("تاريخ وقوع الاعتداء:")]
        [DataType(DataType.Date)]
        public DateTime AssaultDate { get; set; }

        [DisplayName("مكان الاعتداء :")]
        public string AssaultPlace { get; set; }

        [DisplayName("من قام بالتبليغ :")]
        public string AssaultReport { get; set; }

        [DisplayName("هل هناك احتمال لتكرار الاعتداء :")]
        public string AssaultRepeatAttack { get; set; }

        [DisplayName("مستوي الالم الذي شعر به :")]
        public string AssaultLevePain { get; set; }

        [DisplayName("تم تحويل الطفل لمؤسسة مختصة :")]
        public string ChildConvertingFoundation { get; set; }

        [DisplayName("اسم المؤسسة :")]
        public string CenterName { get; set; }

        [DisplayName("كسر")]
        public bool Effects_break { get; set; }

        [DisplayName("جروح")]
        public bool Effects_Wounds { get; set; }

        [DisplayName("كدمات")]
        public bool Effects_Bruising { get; set; }

        [DisplayName("تشويه")]
        public bool Effects_Distortion { get; set; }

        [DisplayName("حروق")]
        public bool Effects_Burns { get; set; }

        [DisplayName("الأهل")]
        public bool intimation_Parents { get; set; }


        [DisplayName("الشرطة")]
        public bool intimation_Police { get; set; }

        [DisplayName("مؤسسة اهلية")]
        public bool intimation_Corporation { get; set; }

        [DisplayName("مدرسة")]
        public bool intimation_School { get; set; }

        [DisplayName("صديق")]
        public bool intimation_Friend { get; set; }


        [DisplayName("وصف الواقعة :")]
        [AllowHtml]
        public string IncidentDescription { get; set; }


        [DisplayName("هل يظهر السلوك الغير مرغوب فيه بشكل :")]
        public string undesirable_Behavior { get; set; }

        [DisplayName("عدد مرات تكرار السلوك  :")]
        public string RepeatBehavior { get; set; }

        [DisplayName("الملاحظين لهذا السلوك  :")]
        public string foreman_For_behavior { get; set; }

        [DisplayName("مدة السلوك:")]
        public string TimeBehavior { get; set; }

        [DisplayName("اضطراب سلوك ومسلك")]
        public bool Disorder_Behavioural { get; set; }

        [DisplayName("اضطراب نفسي")]
        public bool Disorder_Psychological { get; set; }


        [DisplayName("اضطراب التعلم")]
        public bool Disorder_Learn { get; set; }

        [DisplayName("اضطراب النطق")]
        public bool Disorder_Pronounce { get; set; }

        [DisplayName("التبول اللاارادي")]
        public bool Disorder_Urination { get; set; }

        [DisplayName("اضطراب النوم")]
        public bool Disorder_Sleep { get; set; }

        [DisplayName("اضطراب ناتجة عن مواقف صادمة")]
        public bool Disorder_PositionsShocking { get; set; }


        [DisplayName("اضطراب ناتجة عن سوء المعاملة والاهمال")]
        public bool Disorder_Maltreatment { get; set; }

        [DisplayName("تحرش جنسي")]
        public bool Disorder_SexualHarassment { get; set; }


        [DisplayName("اغتصاب واستغلال جنسي")]
        public bool Disorder_rape { get; set; }

        [DisplayName("افاقة جنسية")]
        public bool Disorder_Resuscitatesexual { get; set; }

        [DisplayName("توصيات :")]
        [AllowHtml]
         public string Recommendations { get; set; }

       



    }
}