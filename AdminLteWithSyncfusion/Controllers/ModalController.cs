using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLteWithSyncfusion.Controllers
{
    public class ModalController : Controller
    {
        // GET: Modal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Partial()
        {
            ViewBag.Message = "partial view";
            return PartialView("_Partial");
        }

        public ActionResult Partial2()
        {
            ViewBag.Message = "partial view2";
            return PartialView("_Partial2");
        }
    }
}