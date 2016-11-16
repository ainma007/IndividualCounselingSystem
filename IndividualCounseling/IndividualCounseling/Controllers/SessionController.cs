using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using IndividualCounseling.Models.Session;
using IndividualCounseling.Models;


namespace IndividualCounseling.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult SessionManagement(string CaseID)

        {
            // int.Parse(Session["CaseID"].ToString()) = int.Parse(CaseID.ToString());

            Session["CaseID"] = int.Parse(CaseID.ToString());
            CasesName();
            return View();

           
        }

        private SessionService SessionService;


        public SessionController()
        {

            SessionService = new SessionService(new IndividualCounselingEntities());


        }

        public string CasesName()
        {
            int H = 0;
            H = int.Parse(Session["CaseID"].ToString());
            using (IndividualCounselingEntities entities = new IndividualCounselingEntities())
            {
                Case_Table xx = entities.Case_Table.Where(c => c.CasesID == H)
                               .Select(i => i).Single();


                ViewBag.CasesName = xx.CasesName.ToString();


            }

            return ViewBag.ProjectName;
        }
        public ActionResult Session_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(SessionService.Read().Where(c => c.CaseID==  int.Parse(Session["CaseID"].ToString())).ToDataSourceResult(request));
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Session_Create([DataSourceRequest] DataSourceRequest request,SessionViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                SessionService.Create(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Session_Update([DataSourceRequest] DataSourceRequest request, SessionViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                SessionService.Update(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }


        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Session_Destroy([DataSourceRequest] DataSourceRequest request, SessionViewModel db)
        {
            if (db != null)
            {
                SessionService.Destroy(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }
    }
}