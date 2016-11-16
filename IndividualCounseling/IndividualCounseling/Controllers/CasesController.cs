using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using IndividualCounseling.Models.Cases;
using IndividualCounseling.Models;
using IndividualCounseling.Models.Foreignkey;

namespace IndividualCounseling.Controllers
{
    public class CasesController : Controller
    {
        // GET: Cases
        public ActionResult CasesMnagement(string ProID)
        {
            Session["ProId"] = int.Parse(ProID.ToString());


                Session["ProId"] = int.Parse(ProID.ToString());
            

           
            PopulateGovernorate();
            PopulateArea();
            PopulateUsers();
            ProjectName();
            return View();
        }

        private CasesService CasesService;


        public CasesController()
        {

            CasesService = new CasesService(new IndividualCounselingEntities());


        }

        public void PopulateUsers()
        {
            //  وهنا كمان لازم يكون نشيط حتى يتم ادراجه في المشاريع
            var dataContext = new IndividualCounselingEntities();
            var users = dataContext.Users_Table

                              .Select(c => new userforeignKeyViewModel
                              {
                                  UserID = c.UserID,
                                  FullName = c.FullName
                              })
                              .OrderBy(e => e.UserID);

            ViewData["users"] = users;
            ViewData["defaultUser"] = users.First();
        }
        private void PopulateGovernorate()
        {
            var dataContext = new IndividualCounselingEntities();
            var Governorate = dataContext.Governorate_Table
                        .Select(c => new GovernorateViewModel
                        {
                            GovernorateID = c.GovernorateID,
                            GovernorateName = c.GovernorateArName
                        })
                        .OrderBy(e => e.GovernorateID);

            ViewData["Governorate"] = Governorate;
            ViewData["defaultGovernorate"] = Governorate.First();
        }

        private void PopulateArea()
        {
            var dataContext = new IndividualCounselingEntities();
            var Area = dataContext.Area_Table
                        .Select(c => new AreaViewModel
                        {
                            AreaID = c.AreaID,
                            AreaName = c.AreaArName
                        })
                        .OrderBy(e => e.AreaID);

            ViewData["Area"] = Area;
            ViewData["defaultArea"] = Area.First();
        }

        public string ProjectName()
        {
            int H = 0;
            H =int.Parse(Session["ProId"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                ProjectTable xx = entities.ProjectTable.Where(c => c.ProjectID == H)
                               .Select(i => i).Single();


                ViewBag.ProjectName = xx.ProjectName.ToString();


            }

            return ViewBag.ProjectName;
        }

        public ActionResult Cases_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(CasesService.Read().Where(p => p.ProID == int.Parse(Session["ProId"].ToString())).ToDataSourceResult(request));
        }


        public ActionResult Cases_UserRead([DataSourceRequest] DataSourceRequest request)
        {
            return Json(CasesService.Read().Where(p => p.ProID== int.Parse(Session["ProId"].ToString()) && p.UserID==int.Parse(Session["UserID"].ToString())).ToDataSourceResult(request));
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Cases_Create([DataSourceRequest] DataSourceRequest request, CasesViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                CasesService.Create(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Cases_Update([DataSourceRequest] DataSourceRequest request, CasesViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                CasesService.Update(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }


        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Casess_Destroy([DataSourceRequest] DataSourceRequest request, CasesViewModel db)
        {
            if (db != null)
            {
                CasesService.Destroy(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult GetGovernorate()
        {
            return Json(CasesService.ReadGovernorate(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetArea(int governorateID)
        {
            return Json(CasesService.ReadArea(governorateID), JsonRequestBehavior.AllowGet);
        }

    }
}