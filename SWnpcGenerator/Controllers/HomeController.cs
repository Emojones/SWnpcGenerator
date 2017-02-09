using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SWnpcGenerator.Models;

namespace SWnpcGenerator.Controllers
{
    public class HomeController : Controller
    {
       private Context db = new Context();
        
        public ActionResult Index()
        {           
           return View(); 
        }

        public ActionResult Create()
        {            
           return View();
        }

        // POST: Species/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SpeciesName,WoundThreshold,StrainThreshold,StartExp,Brawn,Agility,Intellect,Cunning,Willpower,Presence")] Species species)
        {
            if (ModelState.IsValid)
            {
                //change this to the new DB that is made up of random stuffs
                db.Spp.Add(species);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(species);
        }


        public ActionResult SavedNPC()
        {            
            return View(db.Spp.ToList());
        }


       
        // GET: Species/Edit/
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TODO update to randomized db
            Species species = db.Spp.Find(id);
            if (species == null)
            {
                return HttpNotFound();
            }
            return View(species);
        }

        // POST: Species/Edit/
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SpeciesName,WoundThreshold,StrainThreshold,StartExp,Brawn,Agility,Intellect,Cunning,Willpower,Presence")] Species species)
        {
            if (ModelState.IsValid)
            {
                db.Entry(species).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(species);
        }

        // GET: Species/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Species species = db.Spp.Find(id);
            if (species == null)
            {
                return HttpNotFound();
            }
            return View(species);
        }

        // POST: Species/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            //TODO: change to randomized db
            Species species = db.Spp.Find(id);
            db.Spp.Remove(species);
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