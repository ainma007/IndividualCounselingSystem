using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using IndividualCounseling.Models.Project;
using IndividualCounseling.Models;

namespace IndividualCounseling.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult ProjectManagment()
        {
            return View();
        }

        private ProjectServices ProjectServices;


        public ProjectController()
        {

            ProjectServices = new ProjectServices(new IndividualCounselingEntities());


        }


        public ActionResult Project_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(ProjectServices.Read().ToDataSourceResult(request));
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Project_Create([DataSourceRequest] DataSourceRequest request, projectViewModle db)
        {
            if (db != null && ModelState.IsValid)
            {
                ProjectServices.Create(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Project_Update([DataSourceRequest] DataSourceRequest request, projectViewModle db)
        {
            if (db != null && ModelState.IsValid)
            {
                ProjectServices.Update(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }


        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Project_Destroy([DataSourceRequest] DataSourceRequest request, projectViewModle db)
        {
            if (db != null)
            {
                ProjectServices.Destroy(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }
    }
}