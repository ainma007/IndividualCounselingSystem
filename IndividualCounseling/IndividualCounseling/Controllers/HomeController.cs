using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using IndividualCounseling.Models.ProjectControl;
using IndividualCounseling.Models;

namespace IndividualCounseling.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        private ProjectControlService ProjectControlService;


        public HomeController()
        {

            ProjectControlService = new ProjectControlService(new IndividualCounselingEntities());


        }


        public ActionResult Project_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(ProjectControlService.ReadIndexUserproject().Where(p=> p.UserID==int.Parse(Session["UserID"].ToString())&& p.Status==true).ToDataSourceResult(request));
        }
    }
}
