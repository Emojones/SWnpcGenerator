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
        SwContext db = new SwContext();
        
        public ActionResult Index()
        {
            try
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SwContext>());
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult RandomNPC()
        {

           return View();
        }

        public ActionResult SavedNPC()
        {
            
            //this is just for testing until the table for saved npcs is actually created
            var savedNpc = new Species()
            {
               SpeciesName = "berthen",
               WoundThreshold = 6,
               StrainThreshold = 1,
               StartExp = 0,
               Brawn = 6,
               Agility = 5,
               Intellect = 4,
               Cunning = 3,
               Willpower = 1,
               Presence = 1
            };

            return View(savedNpc);
        }

        //TODO ActionResult Add
        //TODO ActionResult HttpPost Add

        //TODO ActionResult Edit
        //TODO ActionResult HttpPost Edit

        //TODO ActionResult Delete
        //TODO ActionResult HttpPost Delete
    }
}