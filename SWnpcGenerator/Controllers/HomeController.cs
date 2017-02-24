using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SWnpcGenerator.Models;
using SWnpcGenerator.Repositories;

namespace SWnpcGenerator.Controllers
{
    public class HomeController : Controller
    {
        //TODO: dude, get rid of this
        private Context db = new Context();
        
        public ActionResult Index()
        {           
           return View(); 
        }

        //Create
        public ActionResult RandomNPC()
        {
            var vm = new RandomNPC();

            var randomSpeciesRepository = new RandomSpeciesRepository();
            vm.Species = randomSpeciesRepository.GetRandomSpecies();

            var randomQuirkRepository = new RandomQuirksRepository();
            vm.Quirk = randomQuirkRepository.GetRandomQuirks();

            var randomNameRepository = new RandomName();
            vm.RandomName = randomNameRepository.GenerateName();
                                 
            return View(vm);
        }

        // POST: Species/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RandomNPC(RandomNPC viewModel)
        {
            if (ModelState.IsValid)
            {
                var playerSavedNpc = new PlaverSavedNpc(viewModel);
                var playerRepository = new PlayerRepository();
                playerRepository.save(playerSavedNpc);

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }


        public ActionResult SavedNPC()
        {
            var test = db.playerSaved.ToList();

            return View(test);
        }


       
        // GET: Species/Edit/
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TODO update to randomized db
            PlaverSavedNpc savedNpc = db.playerSaved.Find(id);
            if (savedNpc == null)
            {
                return HttpNotFound();
            }
            return View(savedNpc);
        }

        // POST: Species/Edit/
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PlaverSavedNpc savedNpc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(savedNpc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(savedNpc);
        }

        // GET: Species/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlaverSavedNpc savedNpc = db.playerSaved.Find(id);
            if (savedNpc == null)
            {
                return HttpNotFound();
            }
            return View(savedNpc);
        }

        // POST: Species/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {            
            PlaverSavedNpc savedNpc = db.playerSaved.Find(id);
            db.playerSaved.Remove(savedNpc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}