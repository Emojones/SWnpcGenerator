using SWnpcGenerator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SWnpcGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RandomNPC()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult SavedNPC()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //TODO ActionResult Add
        //TODO ActionResult HttpPost Add

        //TODO ActionResult Edit
        //TODO ActionResult HttpPost Edit

        //TODO ActionResult Delete
        //TODO ActionResult HttpPost Delete
    }
}