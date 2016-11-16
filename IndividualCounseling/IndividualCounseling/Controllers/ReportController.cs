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


        #region(التصنيف حسب الاضطراب)
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
        
        #endregion
    }
}