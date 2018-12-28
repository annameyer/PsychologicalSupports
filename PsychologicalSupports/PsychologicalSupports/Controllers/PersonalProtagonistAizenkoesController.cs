﻿using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using PsychologicalSupports.Models;

namespace PsychologicalSupports.Controllers
{
    public class PersonalProtagonistAizenkoesController : Controller
    {
        private PsychologicalSupportsEntities db = new PsychologicalSupportsEntities();

        // GET: PersonalProtagonistAizenkoes
        public ActionResult Index()
        {
            var personalProtagonistAizenkoes = db.PersonalProtagonistAizenkoes.Include(p => p.Student);
            return View(personalProtagonistAizenkoes.ToList());
        }

        // GET: PersonalProtagonistAizenkoes/Details/5
        public ActionResult Details(long? id,long? id2)
        {
            if (id == null && id2==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalProtagonistAizenko personalProtagonistAizenko = db.PersonalProtagonistAizenkoes.Find(id,id2);
            if (personalProtagonistAizenko == null)
            {
                return HttpNotFound();
            }
            return View(personalProtagonistAizenko);
        }

        // GET: PersonalProtagonistAizenkoes/Create
        public ActionResult Create()
        {
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "FIO");
            return View();
        }

        // POST: PersonalProtagonistAizenkoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonaAnxietyScaleID,StudentID,Temperament,Type")] PersonalProtagonistAizenko personalProtagonistAizenko)
        {
            if (ModelState.IsValid)
            {
                db.PersonalProtagonistAizenkoes.Add(personalProtagonistAizenko);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "FIO", personalProtagonistAizenko.StudentID);
            return View(personalProtagonistAizenko);
        }

        // GET: PersonalProtagonistAizenkoes/Edit/5
        public ActionResult Edit(long? id,long? id2)
        {
            if (id == null && id2==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalProtagonistAizenko personalProtagonistAizenko = db.PersonalProtagonistAizenkoes.Find(id,id2);
            if (personalProtagonistAizenko == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "FIO", personalProtagonistAizenko.StudentID);
            return View(personalProtagonistAizenko);
        }

        // POST: PersonalProtagonistAizenkoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonaAnxietyScaleID,StudentID,Temperament,Type")] PersonalProtagonistAizenko personalProtagonistAizenko)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personalProtagonistAizenko).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "FIO", personalProtagonistAizenko.StudentID);
            return View(personalProtagonistAizenko);
        }

        // GET: PersonalProtagonistAizenkoes/Delete/5
        public ActionResult Delete(long? id,long? id2)
        {
            if (id == null && id2==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalProtagonistAizenko personalProtagonistAizenko = db.PersonalProtagonistAizenkoes.Find(id,id2);
            if (personalProtagonistAizenko == null)
            {
                return HttpNotFound();
            }
            return View(personalProtagonistAizenko);
        }

        // POST: PersonalProtagonistAizenkoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id,long id2)
        {
            PersonalProtagonistAizenko personalProtagonistAizenko = db.PersonalProtagonistAizenkoes.Find(id,id2);
            db.PersonalProtagonistAizenkoes.Remove(personalProtagonistAizenko);
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
