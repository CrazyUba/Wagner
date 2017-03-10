using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wagner2.Controllers
{

    public class person
    {
        public string  Name { get; set; }
    }

    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            person papa = new person();
            papa.Name = "Paul";


            return View(papa);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}