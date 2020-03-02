using System.Collections.Generic;
using System.Web.Mvc;

namespace AdminLteWithSyncfusion.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var models = new List<MyModel>();
            models.Add(new MyModel { Id = 1, Name = "Name 1", Address = "Address 1" });
            models.Add(new MyModel { Id = 2, Name = "Name 2", Address = "Address 2" });
            models.Add(new MyModel { Id = 3, Name = "Name 3", Address = "Address 3" });

            ViewBag.Models = models;

            return View();
        }

        [HttpGet]
        public ActionResult AnotherLink()
        {
            return View("Index");
        }
    }

    public class MyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
