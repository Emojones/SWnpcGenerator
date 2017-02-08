using SWnpcGenerator.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace SWnpcGenerator.Controllers
{
    public class HomeController : Controller
    {
        Context context = new Context();
        
        public ActionResult Index()
        {
           
           return View();
 
        }

        public ActionResult RandomNPC()
        {

           return View();
        }

        public ActionResult SavedNPC()
        {

            //this is just for testing until the table for saved npcs is actually created
            var test = context.Spp
                .Include(c => c.SpeciesName)
                .Where(d => d.Id == 1);
            
            return View(test);
        }

        //TODO ActionResult Add
        //TODO ActionResult HttpPost Add

        //TODO ActionResult Edit
        //TODO ActionResult HttpPost Edit

        //TODO ActionResult Delete
        //TODO ActionResult HttpPost Delete
    }
}