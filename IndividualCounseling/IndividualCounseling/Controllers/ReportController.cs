using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using IndividualCounseling.Models;


namespace IndividualCounseling.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Report(string ProID)
        {
            Session["ProId"] = int.Parse(ProID.ToString());

            ProjectName();



            //اجمالي الاحصائيات حسب المحافظات
            CountNorthGaza();
            CountGaza();
            CountDair();
            CountKhan();
            CountRafah();

            //NorthGaza

            CountMale0_5NorthGaza();
            CountFemal0_5NorthGaza();
            CountMale6_12NorthGaza();
            CountFemal6_12NorthGaza();
            CountMale13_17NorthGaza();
            CountFemal13_17NorthGaza();

            //Gaza
            CountMale0_5Gaza();
            CountFemal0_5Gaza();
            CountMale6_12Gaza();
            CountFemal6_12Gaza();
            CountMale13_17Gaza();
            CountFemal13_17Gaza();

            //

            CountMale0_5Dair();
            CountFemal0_5Dair();
            CountMale6_12Dair();
            CountFemal6_12Dair();
            CountMale13_17Dair();
            CountFemal13_17Dair();

            //

            CountMale0_5Khan();
            CountFemal0_5Khan();
            CountMale6_12Khan();
            CountFemal6_12Khan();
            CountMale13_17Khan();
            CountFemal13_17Khan();

            //

            CountMale0_5Rafah();
            CountFemal0_5Rafah();
            CountMale6_12Rafah();
            CountFemal6_12Rafah();
            CountMale13_17Rafah();
            CountFemal13_17Rafah();
            //
            CountNorthGazaMale();
            CountNorthGazaFemal();
            CountGazaMale();
            CountGazaFemal();
            CountDairMale();
            CountDairFemal();
            CountKhanMale();
            CountKhanFemal();
            CountRafahMale();
            CountRafahFemal();
            //
            CountPsychologicalProblemsNorthGaza();
            CountPsychologicalProblemsGaza();
            CountPsychologicalProblemsDair();
            CountPsychologicalProblemsKhan();
            CountPsychologicalProblemsRafah();

            //

            CountBehavioralproblemsNorthGaza();
            CountBehavioralproblemsGaza();
            CountBehavioralproblemsDair();
            CountBehavioralproblemsKhan();
            CountBehavioralproblemsRafah();
            //

            CountEducationalproblemsNorthGaza();
            CountEducationalproblemsGaza();
            CountEducationalproblemsDair();
            CountEducationalproblemsKhan();
            CountEducationalproblemsRafah();

            //

            CountPronounceNorthGaza();
            CountPronounceGaza();
            CountPronounceDair();
            CountPronounceKhan();
            CountPronounceRafah();
            //
            CountMaltreatmentNorthGaza();
            CountMaltreatmentGaza();
            CountMaltreatmentDair();
            CountMaltreatmentKhan();
            CountMaltreatmentRafah();

            //

            CountSexualNorthGaza();
            CountSexualGaza();
            CountSexualDair();
            CountSexualKhan();
            CountSexualRafah();

            //
            CountPsychologicalProblemsMale();
            CountPsychologicalProblemsFemale();
            CountBehavioralproblemsNorthMale();
            CountBehavioralproblemsNorthFemale();
            CountEducationalproblemsMale();
            CountEducationalproblemsFemale();
            CountPronounceMale();
            CountPronounceFemale();
            CountMaltreatmentMale();
            CountMaltreatmentFemale();
            CountSexualMale();
            CountSexualFemale();

            return View();
        }

        public string ProjectName()
        {
            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ProjectTable xx = entities.ProjectTable.Where(c => c.ProjectID == H)
                               .Select(i => i).Single();


                ViewBag.ProjectName = xx.ProjectName.ToString();


            }

            return ViewBag.ProjectName;
        }


        #region(الاجمالي لعدد الحالات حسب المحافظات)
        private int CountNorthGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountNorthGaza = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 1 select new { i.CasesID }).Count();


            }
            return ViewBag.CountNorthGaza;

        }

        private int CountGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountGaza = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 2 select new { i.CasesID }).Count();


            }
            return ViewBag.CountGaza;

        }

        private int CountDair()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountDair = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 3 select new { i.CasesID }).Count();


            }
            return ViewBag.CountDair;

        }

        private int CountKhan()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountKhan = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 4 select new { i.CasesID }).Count();


            }
            return ViewBag.CountKhan;

        }

        private int CountRafah()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountRafah = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 5 select new { i.CasesID }).Count();


            }
            return ViewBag.CountRafah;

        }
        #endregion


        #region(الاجمالي لعدد الحالات حسب المحافظات)
        private int CountNorthGazaMale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountNorthGazaMale = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 1 && i.CasesGender=="ذكر" select new { i.CasesID }).Count();


            }
            return ViewBag.CountNorthGazaMale;

        }

        private int CountNorthGazaFemal()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountNorthGazaFemal = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 1 && i.CasesGender == "أنثى" select new { i.CasesID }).Count();


            }
            return ViewBag.CountNorthGazaFemal;

        }

        private int CountGazaMale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountGazaMale = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 2 && i.CasesGender == "ذكر" select new { i.CasesID }).Count();


            }
            return ViewBag.CountGazaMale;

        }
        private int CountGazaFemal()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountGazaFemal = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 2 && i.CasesGender == "أنثى" select new { i.CasesID }).Count();


            }
            return ViewBag.CountGazaFemal;

        }

        private int CountDairMale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountDairMale = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 3 && i.CasesGender == "ذكر" select new { i.CasesID }).Count();


            }
            return ViewBag.CountDairMale;

        }

        private int CountDairFemal()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountDairFemal = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 3 && i.CasesGender == "أنثى" select new { i.CasesID }).Count();


            }
            return ViewBag.CountDairFemal;

        }

        private int CountKhanMale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountKhanMale = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 4 && i.CasesGender == "ذكر" select new { i.CasesID }).Count();


            }
            return ViewBag.CountKhanMale;

        }

        private int CountKhanFemal()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountKhanFemal = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 4 && i.CasesGender == "أنثى" select new { i.CasesID }).Count();


            }
            return ViewBag.CountKhanFemal;

        }

        private int CountRafahMale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountRafahMale = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 5 && i.CasesGender == "ذكر" select new { i.CasesID }).Count();


            }
            return ViewBag.CountRafahMale;

        }
        private int CountRafahFemal()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountRafahFemal = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 5 && i.CasesGender == "أنثى" select new { i.CasesID }).Count();


            }
            return ViewBag.CountRafahFemal;

        }
        #endregion


        #region(احصائيات شمال غزة حسب الاعمار)
        private int CountMale0_5NorthGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale0_5NorthGaza = (from i in entities.Case_Table where i.CasesAge >= 0 && i.CasesAge <= 5 && i.ProjectID == H && i.CasesGender=="ذكر"&& i.GovernorateID==1 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale0_5NorthGaza;

        }
        private int CountFemal0_5NorthGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.ountFemal0_5NorthGaza = (from i in entities.Case_Table where i.CasesAge >= 0 && i.CasesAge <= 5 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 1 select new { i.CasesID }).Count();


            }
            return ViewBag.ountFemal0_5NorthGaza;

        }

        private int CountMale6_12NorthGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale6_12NorthGaza = (from i in entities.Case_Table where i.CasesAge >= 6 && i.CasesAge <= 12 && i.ProjectID == H && i.CasesGender == "ذكر" && i.GovernorateID == 1 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale6_12NorthGaza;

        }
        private int CountFemal6_12NorthGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountFemal6_12NorthGaza = (from i in entities.Case_Table where i.CasesAge >= 6 && i.CasesAge <= 12 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 1 select new { i.CasesID }).Count();


            }
            return ViewBag.CountFemal6_12NorthGaza;

        }

        private int CountMale13_17NorthGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale13_17NorthGaza = (from i in entities.Case_Table where i.CasesAge >= 13 && i.CasesAge <= 17 && i.ProjectID == H && i.CasesGender == "ذكر" && i.GovernorateID == 1 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale13_17NorthGaza;

        }

        private int CountFemal13_17NorthGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountFemal13_17NorthGaza = (from i in entities.Case_Table where i.CasesAge >= 13 && i.CasesAge <= 17 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 1 select new { i.CasesID }).Count();


            }
            return ViewBag.CountFemal13_17NorthGaza;

        }

        #endregion

        #region(احصائيات  غزة حسب الاعمار)
        private int CountMale0_5Gaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale0_5Gaza = (from i in entities.Case_Table where i.CasesAge >= 0 && i.CasesAge <= 5 && i.ProjectID == H && i.CasesGender == "ذكر" && i.GovernorateID == 2 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale0_5Gaza;

        }
        private int CountFemal0_5Gaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountFemal0_5Gaza = (from i in entities.Case_Table where i.CasesAge >= 0 && i.CasesAge <= 5 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 2 select new { i.CasesID }).Count();


            }
            return ViewBag.CountFemal0_5Gaza;

        }

        private int CountMale6_12Gaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale6_12Gaza = (from i in entities.Case_Table where i.CasesAge >= 6 && i.CasesAge <= 12 && i.ProjectID == H && i.CasesGender == "ذكر" && i.GovernorateID == 2 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale6_12Gaza;

        }
        private int CountFemal6_12Gaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountFemal6_12Gaza = (from i in entities.Case_Table where i.CasesAge >= 6 && i.CasesAge <= 12 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 2 select new { i.CasesID }).Count();


            }
            return ViewBag.CountFemal6_12Gaza;

        }

        private int CountMale13_17Gaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale13_17NorthGaza = (from i in entities.Case_Table where i.CasesAge >= 13 && i.CasesAge <= 17 && i.ProjectID == H && i.CasesGender == "ذكر" && i.GovernorateID == 2 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale13_17NorthGaza;

        }

        private int CountFemal13_17Gaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountFemal13_17Gaza = (from i in entities.Case_Table where i.CasesAge >= 13 && i.CasesAge <= 17 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 2 select new { i.CasesID }).Count();


            }
            return ViewBag.CountFemal13_17Gaza;

        }

        #endregion

        #region(احصائيات  دير البلح حسب الاعمار)
        private int CountMale0_5Dair()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale0_5Dair = (from i in entities.Case_Table where i.CasesAge >= 0 && i.CasesAge <= 5 && i.ProjectID == H && i.CasesGender == "ذكر" && i.GovernorateID == 3 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale0_5Dair;

        }
        private int CountFemal0_5Dair()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountFemal0_5Dair = (from i in entities.Case_Table where i.CasesAge >= 0 && i.CasesAge <= 5 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 3 select new { i.CasesID }).Count();


            }
            return ViewBag.CountFemal0_5Dair;

        }

        private int CountMale6_12Dair()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale6_12Dair = (from i in entities.Case_Table where i.CasesAge >= 6 && i.CasesAge <= 12 && i.ProjectID == H && i.CasesGender == "ذكر" && i.GovernorateID == 3 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale6_12Dair;

        }
        private int CountFemal6_12Dair()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountFemal6_12Dair = (from i in entities.Case_Table where i.CasesAge >= 6 && i.CasesAge <= 12 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 3 select new { i.CasesID }).Count();


            }
            return ViewBag.CountFemal6_12Dair;

        }

        private int CountMale13_17Dair()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale13_17NorthDair = (from i in entities.Case_Table where i.CasesAge >= 13 && i.CasesAge <= 17 && i.ProjectID == H && i.CasesGender == "ذكر" && i.GovernorateID == 3 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale13_17NorthDair;

        }

        private int CountFemal13_17Dair()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountFemal13_17Dair = (from i in entities.Case_Table where i.CasesAge >= 13 && i.CasesAge <= 17 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 3 select new { i.CasesID }).Count();


            }
            return ViewBag.CountFemal13_17Dair;

        }

        #endregion

        #region(احصائيات  خانيونس حسب الاعمار)
        private int CountMale0_5Khan()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale0_5Khan = (from i in entities.Case_Table where i.CasesAge >= 0 && i.CasesAge <= 5 && i.ProjectID == H && i.CasesGender == "ذكر" && i.GovernorateID == 4 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale0_5Khan;

        }
        private int CountFemal0_5Khan()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountFemal0_5Khan = (from i in entities.Case_Table where i.CasesAge >= 0 && i.CasesAge <= 5 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 4 select new { i.CasesID }).Count();


            }
            return ViewBag.CountFemal0_5Khan;

        }

        private int CountMale6_12Khan()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale6_12Khan = (from i in entities.Case_Table where i.CasesAge >= 6 && i.CasesAge <= 12 && i.ProjectID == H && i.CasesGender == "ذكر" && i.GovernorateID == 4 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale6_12Khan;

        }
        private int CountFemal6_12Khan()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountFemal6_12Khan = (from i in entities.Case_Table where i.CasesAge >= 6 && i.CasesAge <= 12 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 4 select new { i.CasesID }).Count();


            }
            return ViewBag.CountFemal6_12Khan;

        }

        private int CountMale13_17Khan()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale13_17NorthKhan = (from i in entities.Case_Table where i.CasesAge >= 13 && i.CasesAge <= 17 && i.ProjectID == H && i.CasesGender == "ذكر" && i.GovernorateID == 4 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale13_17NorthKhan;

        }

        private int CountFemal13_17Khan()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountFemal13_17Khan = (from i in entities.Case_Table where i.CasesAge >= 13 && i.CasesAge <= 17 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 4 select new { i.CasesID }).Count();


            }
            return ViewBag.CountFemal13_17Khan;

        }

        #endregion

        #region(احصائيات  رفح حسب الاعمار)
        private int CountMale0_5Rafah()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale0_5Rafah = (from i in entities.Case_Table where i.CasesAge >= 0 && i.CasesAge <= 5 && i.ProjectID == H && i.CasesGender == "ذكر" && i.GovernorateID == 5 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale0_5Rafah;

        }
        private int CountFemal0_5Rafah()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountFemal0_5Rafah = (from i in entities.Case_Table where i.CasesAge >= 0 && i.CasesAge <= 5 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 5 select new { i.CasesID }).Count();


            }
            return ViewBag.CountFemal0_5Rafah;

        }

        private int CountMale6_12Rafah()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale6_12Rafah = (from i in entities.Case_Table where i.CasesAge >= 6 && i.CasesAge <= 12 && i.ProjectID == H && i.CasesGender == "ذكر" && i.GovernorateID == 5 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale6_12Rafah;

        }
        private int CountFemal6_12Rafah()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountFemal6_12Rafah = (from i in entities.Case_Table where i.CasesAge >= 6 && i.CasesAge <= 12 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 5 select new { i.CasesID }).Count();


            }
            return ViewBag.CountFemal6_12Rafah;

        }

        private int CountMale13_17Rafah()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMale13_17NorthRafah = (from i in entities.Case_Table where i.CasesAge >= 13 && i.CasesAge <= 17 && i.ProjectID == H && i.CasesGender == "ذكر" && i.GovernorateID == 5 select new { i.CasesID }).Count();


            }
            return ViewBag.CountMale13_17NorthRafah;

        }

        private int CountFemal13_17Rafah()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountFemal13_17Rafah = (from i in entities.Case_Table where i.CasesAge >= 13 && i.CasesAge <= 17 && i.ProjectID == H && i.CasesGender == "أنثى" && i.GovernorateID == 5 select new { i.CasesID }).Count();


            }
            return ViewBag.CountFemal13_17Rafah;

        }

        #endregion


        #region(التصنيف ضراب المشاكل النفسية)
        private int CountPsychologicalProblemsNorthGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_Psychological = (from i in entities.Case_Table where i.ProjectID == H &&  i.GovernorateID == 1 && i.Disorder_Psychological==true select new { i.CasesID }).Count();
                int Disorder_Sleep = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 1 && i.Disorder_Sleep == true select new { i.CasesID }).Count();
                int Disorder_PositionsShocking = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 1 && i.Disorder_PositionsShocking == true select new { i.CasesID }).Count();

                ViewBag.CountPsychologicalProblemsNorthGaza = (Disorder_Psychological + Disorder_Sleep + Disorder_PositionsShocking);
            }
            return ViewBag.CountPsychologicalProblemsNorthGaza;

        }

        private int CountPsychologicalProblemsGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_Psychological = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 2 && i.Disorder_Psychological == true select new { i.CasesID }).Count();
                int Disorder_Sleep = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 2 && i.Disorder_Sleep == true select new { i.CasesID }).Count();
                int Disorder_PositionsShocking = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 2 && i.Disorder_PositionsShocking == true select new { i.CasesID }).Count();

                ViewBag.CountPsychologicalProblemsGaza = (Disorder_Psychological + Disorder_Sleep + Disorder_PositionsShocking);
            }
            return ViewBag.CountPsychologicalProblemsGaza;

        }

        private int CountPsychologicalProblemsDair()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_Psychological = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 3 && i.Disorder_Psychological == true select new { i.CasesID }).Count();
                int Disorder_Sleep = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 3 && i.Disorder_Sleep == true select new { i.CasesID }).Count();
                int Disorder_PositionsShocking = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 3 && i.Disorder_PositionsShocking == true select new { i.CasesID }).Count();

                ViewBag.CountPsychologicalProblemsDair = (Disorder_Psychological + Disorder_Sleep + Disorder_PositionsShocking);
            }
            return ViewBag.CountPsychologicalProblemsDair;

        }

        private int CountPsychologicalProblemsKhan()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_Psychological = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 4 && i.Disorder_Psychological == true select new { i.CasesID }).Count();
                int Disorder_Sleep = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 4 && i.Disorder_Sleep == true select new { i.CasesID }).Count();
                int Disorder_PositionsShocking = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 4 && i.Disorder_PositionsShocking == true select new { i.CasesID }).Count();

                ViewBag.CountPsychologicalProblemsKhan = (Disorder_Psychological + Disorder_Sleep + Disorder_PositionsShocking);
            }
            return ViewBag.CountPsychologicalProblemsKhan;

        }

        private int CountPsychologicalProblemsRafah()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_Psychological = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 5 && i.Disorder_Psychological == true select new { i.CasesID }).Count();
                int Disorder_Sleep = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 5 && i.Disorder_Sleep == true select new { i.CasesID }).Count();
                int Disorder_PositionsShocking = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 5 && i.Disorder_PositionsShocking == true select new { i.CasesID }).Count();

                ViewBag.CountPsychologicalProblemsRafah = (Disorder_Psychological + Disorder_Sleep + Disorder_PositionsShocking);
            }
            return ViewBag.CountPsychologicalProblemsRafah;

        }


        #endregion

        #region(التصنيف ضراب المشاكل السلوكية)
        private int CountBehavioralproblemsNorthGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_Behavioural = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 1 && i.Disorder_Behavioural == true select new { i.CasesID }).Count();
                int Disorder_Urination = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 1 && i.Disorder_Urination == true select new { i.CasesID }).Count();

                ViewBag.CountBehavioralproblemsNorthGaza = (Disorder_Behavioural + Disorder_Urination);
            }
            return ViewBag.CountBehavioralproblemsNorthGaza;

        }

        private int CountBehavioralproblemsGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_Behavioural = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 2 && i.Disorder_Behavioural == true select new { i.CasesID }).Count();
                int Disorder_Urination = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 2 && i.Disorder_Urination == true select new { i.CasesID }).Count();

                ViewBag.CountBehavioralproblemsGaza = (Disorder_Behavioural + Disorder_Urination);
            }
            return ViewBag.CountBehavioralproblemsGaza;

        }

        private int CountBehavioralproblemsDair()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_Behavioural = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 3 && i.Disorder_Behavioural == true select new { i.CasesID }).Count();
                int Disorder_Urination = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 3 && i.Disorder_Urination == true select new { i.CasesID }).Count();

                ViewBag.CountBehavioralproblemsDair = (Disorder_Behavioural + Disorder_Urination);
            }
            return ViewBag.CountBehavioralproblemsDair;

        }

        private int CountBehavioralproblemsKhan()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_Behavioural = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 4 && i.Disorder_Behavioural == true select new { i.CasesID }).Count();
                int Disorder_Urination = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 4 && i.Disorder_Urination == true select new { i.CasesID }).Count();

                ViewBag.CountBehavioralproblemsKhan = (Disorder_Behavioural + Disorder_Urination);
            }
            return ViewBag.CountBehavioralproblemsKhan;

        }

        private int CountBehavioralproblemsRafah()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_Behavioural = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 5 && i.Disorder_Behavioural == true select new { i.CasesID }).Count();
                int Disorder_Urination = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 5 && i.Disorder_Urination == true select new { i.CasesID }).Count();

                ViewBag.CountBehavioralproblemsRafah = (Disorder_Behavioural + Disorder_Urination);
            }
            return ViewBag.CountBehavioralproblemsRafah;

        }


        #endregion

        #region(التصنيف ضراب المشاكل التربوية)
        private int CountEducationalproblemsNorthGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {

                ViewBag.CountEducationalproblemsNorthGaza = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 1 && i.Disorder_Learn == true select new { i.CasesID }).Count();
            }
            return ViewBag.CountEducationalproblemsNorthGaza;

        }

        private int CountEducationalproblemsGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountEducationalproblemsGaza = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 2 && i.Disorder_Learn == true select new { i.CasesID }).Count();

            }
            return ViewBag.CountEducationalproblemsGaza;

        }

        private int CountEducationalproblemsDair()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountEducationalproblemsDair = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 3 && i.Disorder_Learn == true select new { i.CasesID }).Count();

            }
            return ViewBag.CountEducationalproblemsDair;

        }

        private int CountEducationalproblemsKhan()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountEducationalproblemsKhan = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 4 && i.Disorder_Learn == true select new { i.CasesID }).Count();

            }
            return ViewBag.CountEducationalproblemsKhan;

        }

        private int CountEducationalproblemsRafah()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountEducationalproblemsRafah = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 5 && i.Disorder_Learn == true select new { i.CasesID }).Count();

            }
            return ViewBag.CountEducationalproblemsRafah;

        }


        #endregion

        #region(التصنيف سوء مشاكل نطق)
        private int CountPronounceNorthGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {

                ViewBag.CountPronounceNorthGaza = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 1 && i.Disorder_Pronounce == true select new { i.CasesID }).Count();
            }
            return ViewBag.CountPronounceNorthGaza;

        }

        private int CountPronounceGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountPronounceGaza = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 2 && i.Disorder_Pronounce == true select new { i.CasesID }).Count();

            }
            return ViewBag.CountPronounceGaza;

        }

        private int CountPronounceDair()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountPronounceDair = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 3 && i.Disorder_Pronounce == true select new { i.CasesID }).Count();

            }
            return ViewBag.CountPronounceDair;

        }

        private int CountPronounceKhan()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountPronounceKhan = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 4 && i.Disorder_Pronounce == true select new { i.CasesID }).Count();

            }
            return ViewBag.CountPronounceKhan;

        }

        private int CountPronounceRafah()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountPronounceRafah = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 5 && i.Disorder_Pronounce == true select new { i.CasesID }).Count();

            }
            return ViewBag.CountPronounceRafah;

        }


        #endregion

        #region(التصنيف سوء المعاملة)
        private int CountMaltreatmentNorthGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {

                ViewBag.CountMaltreatmentNorthGaza = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 1 && i.Disorder_Maltreatment == true select new { i.CasesID }).Count();
            }
            return ViewBag.CountMaltreatmentNorthGaza;

        }

        private int CountMaltreatmentGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMaltreatmentGaza = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 2 && i.Disorder_Maltreatment == true select new { i.CasesID }).Count();

            }
            return ViewBag.CountMaltreatmentGaza;

        }

        private int CountMaltreatmentDair()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMaltreatmentDair = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 3 && i.Disorder_Maltreatment == true select new { i.CasesID }).Count();

            }
            return ViewBag.CountMaltreatmentDair;

        }

        private int CountMaltreatmentKhan()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMaltreatmentKhan = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 4 && i.Disorder_Maltreatment == true select new { i.CasesID }).Count();

            }
            return ViewBag.CountMaltreatmentKhan;

        }

        private int CountMaltreatmentRafah()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ViewBag.CountMaltreatmentRafah = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 5 && i.Disorder_Maltreatment == true select new { i.CasesID }).Count();

            }
            return ViewBag.CountMaltreatmentRafah;

        }


        #endregion


        #region(التصنيف  المشاكل الجنسية)
        private int CountSexualNorthGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_SexualHarassment = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 1 && i.Disorder_SexualHarassment == true select new { i.CasesID }).Count();
                int Disorder_rape = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 1 && i.Disorder_rape == true select new { i.CasesID }).Count();
                int Disorder_Resuscitatesexual = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 1 && i.Disorder_Resuscitatesexual == true select new { i.CasesID }).Count();

                ViewBag.CountSexualNorthGaza = (Disorder_SexualHarassment + Disorder_rape + Disorder_Resuscitatesexual);
            }
            return ViewBag.CountSexualNorthGaza;

        }

        private int CountSexualGaza()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_SexualHarassment = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 2 && i.Disorder_SexualHarassment == true select new { i.CasesID }).Count();
                int Disorder_rape = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 2 && i.Disorder_rape == true select new { i.CasesID }).Count();
                int Disorder_Resuscitatesexual = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 2 && i.Disorder_Resuscitatesexual == true select new { i.CasesID }).Count();

                ViewBag.CountSexualGaza = (Disorder_SexualHarassment + Disorder_rape + Disorder_Resuscitatesexual);
            }
            return ViewBag.CountSexualGaza;

        }

        private int CountSexualDair()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_SexualHarassment = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 3 && i.Disorder_SexualHarassment == true select new { i.CasesID }).Count();
                int Disorder_rape = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 3 && i.Disorder_rape == true select new { i.CasesID }).Count();
                int Disorder_Resuscitatesexual = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 3 && i.Disorder_Resuscitatesexual == true select new { i.CasesID }).Count();

                ViewBag.CountSexualDair = (Disorder_SexualHarassment + Disorder_rape + Disorder_Resuscitatesexual);
            }
            return ViewBag.CountSexualDair;

        }

        private int CountSexualKhan()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_SexualHarassment = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 4 && i.Disorder_SexualHarassment == true select new { i.CasesID }).Count();
                int Disorder_rape = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 4 && i.Disorder_rape == true select new { i.CasesID }).Count();
                int Disorder_Resuscitatesexual = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 4 && i.Disorder_Resuscitatesexual == true select new { i.CasesID }).Count();

                ViewBag.CountSexualKhan = (Disorder_SexualHarassment + Disorder_rape + Disorder_Resuscitatesexual);
            }
            return ViewBag.CountSexualKhan;

        }

        private int CountSexualRafah()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_SexualHarassment = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 5 && i.Disorder_SexualHarassment == true select new { i.CasesID }).Count();
                int Disorder_rape = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 5 && i.Disorder_rape == true select new { i.CasesID }).Count();
                int Disorder_Resuscitatesexual = (from i in entities.Case_Table where i.ProjectID == H && i.GovernorateID == 5 && i.Disorder_Resuscitatesexual == true select new { i.CasesID }).Count();

                ViewBag.CountSexualRafah = (Disorder_SexualHarassment + Disorder_rape + Disorder_Resuscitatesexual);
            }
            return ViewBag.CountSexualRafah;

        }


        #endregion

        #region

        private int CountPsychologicalProblemsMale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_Psychological = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "ذكر" && i.Disorder_Psychological == true select new { i.CasesID }).Count();
                int Disorder_Sleep = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "ذكر" && i.Disorder_Sleep == true select new { i.CasesID }).Count();
                int Disorder_PositionsShocking = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "ذكر" && i.Disorder_PositionsShocking == true select new { i.CasesID }).Count();

                ViewBag.CountPsychologicalProblemsMale = (Disorder_Psychological + Disorder_Sleep + Disorder_PositionsShocking);
            }
            return ViewBag.CountPsychologicalProblemsMale;

        }

        private int CountPsychologicalProblemsFemale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_Psychological = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "أنثى" && i.Disorder_Psychological == true select new { i.CasesID }).Count();
                int Disorder_Sleep = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "أنثى" && i.Disorder_Sleep == true select new { i.CasesID }).Count();
                int Disorder_PositionsShocking = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "أنثى" && i.Disorder_PositionsShocking == true select new { i.CasesID }).Count();

                ViewBag.CountPsychologicalProblemsFemale = (Disorder_Psychological + Disorder_Sleep + Disorder_PositionsShocking);
            }
            return ViewBag.CountPsychologicalProblemsFemale;

        }

        private int CountBehavioralproblemsNorthMale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_Behavioural = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "ذكر" && i.Disorder_Behavioural == true select new { i.CasesID }).Count();
                int Disorder_Urination = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "ذكر" && i.Disorder_Urination == true select new { i.CasesID }).Count();

                ViewBag.CountBehavioralproblemsNorthMale = (Disorder_Behavioural + Disorder_Urination);
            }
            return ViewBag.CountBehavioralproblemsNorthMale;

        }

        private int CountBehavioralproblemsNorthFemale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_Behavioural = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "أنثى" && i.Disorder_Behavioural == true select new { i.CasesID }).Count();
                int Disorder_Urination = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "أنثى" && i.Disorder_Urination == true select new { i.CasesID }).Count();

                ViewBag.CountBehavioralproblemsNorthFemale = (Disorder_Behavioural + Disorder_Urination);
            }
            return ViewBag.CountBehavioralproblemsNorthFemale;

        }

        private int CountEducationalproblemsMale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {

                ViewBag.CountEducationalproblemsMale = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "ذكر"  && i.Disorder_Learn == true select new { i.CasesID }).Count();
            }
            return ViewBag.CountEducationalproblemsMale;

        }
        private int CountEducationalproblemsFemale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {

                ViewBag.CountEducationalproblemsFemale = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "أنثى" && i.Disorder_Learn == true select new { i.CasesID }).Count();
            }
            return ViewBag.CountEducationalproblemsFemale;

        }


        private int CountPronounceMale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {

                ViewBag.CountPronounceMale = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "ذكر" && i.Disorder_Pronounce == true select new { i.CasesID }).Count();
            }
            return ViewBag.CountPronounceMale;

        }

        private int CountPronounceFemale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {

                ViewBag.CountPronounceFemale = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "أنثى" && i.Disorder_Pronounce == true select new { i.CasesID }).Count();
            }
            return ViewBag.CountPronounceFemale;

        }

        private int CountMaltreatmentMale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {

                ViewBag.CountMaltreatmentMale = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "ذكر" && i.Disorder_Maltreatment == true select new { i.CasesID }).Count();
            }
            return ViewBag.CountMaltreatmentMale;

        }

        private int CountMaltreatmentFemale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {

                ViewBag.CountMaltreatmentFemale = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "أنثى" && i.Disorder_Maltreatment == true select new { i.CasesID }).Count();
            }
            return ViewBag.CountMaltreatmentFemale;

        }


        private int CountSexualMale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_SexualHarassment = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "ذكر" && i.Disorder_SexualHarassment == true select new { i.CasesID }).Count();
                int Disorder_rape = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "ذكر" && i.Disorder_rape == true select new { i.CasesID }).Count();
                int Disorder_Resuscitatesexual = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "ذكر" && i.Disorder_Resuscitatesexual == true select new { i.CasesID }).Count();

                ViewBag.CountSexualMale = (Disorder_SexualHarassment + Disorder_rape + Disorder_Resuscitatesexual);
            }
            return ViewBag.CountSexualMale;

        }

        private int CountSexualFemale()
        {

            int H = 0;
            H = int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                int Disorder_SexualHarassment = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "أنثى" && i.Disorder_SexualHarassment == true select new { i.CasesID }).Count();
                int Disorder_rape = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "أنثى" && i.Disorder_rape == true select new { i.CasesID }).Count();
                int Disorder_Resuscitatesexual = (from i in entities.Case_Table where i.ProjectID == H && i.CasesGender == "أنثى" && i.Disorder_Resuscitatesexual == true select new { i.CasesID }).Count();

                ViewBag.CountSexualFemale = (Disorder_SexualHarassment + Disorder_rape + Disorder_Resuscitatesexual);
            }
            return ViewBag.CountSexualFemale;

        }

        #endregion
    }
}