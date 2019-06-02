﻿using PsychologicalSupports.Enum;
using PsychologicalSupports.Models;
using PsychologicalSupports.Models.Dependencies;
using System.Net;
using System.Web.Mvc;

namespace PsychologicalSupports.Controllers
{
    public class Intellectual_7_ClassController : Controller
    {
        private readonly IPsychologicalSupportsContext _psychologicalSupportsContext;
        private IRepository<Intellectual_7_Class> _repository;

        public Intellectual_7_ClassController(IRepository<Intellectual_7_Class> repository, IPsychologicalSupportsContext context)
        {
            _psychologicalSupportsContext = context;
            _repository = repository;
        }

         
        public ActionResult Index()
        {
            return View(_repository.List());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Intellectual_7_Class intellectual_7_Class = _repository.Get(id);
            if (intellectual_7_Class == null)
            {
                return HttpNotFound();
            }

            return View(intellectual_7_Class);
        }

        public ActionResult Create(int Id)
        {
            GetCurrentStudent studentName = new GetCurrentStudent();
            ViewBag.StudentName = studentName.GetStudentId(Id);
            return View();
        }

        [HttpPost]
        public ActionResult Create(Intellectual_7_Class intellectual_7_Class, int Id)
        {
            intellectual_7_Class.StudentID = Id;
            if (ModelState.IsValid)
            {
                _repository.Create(intellectual_7_Class);
                return RedirectToAction("Index");
            }

            return View(intellectual_7_Class);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetCurrentStudent studentName = new GetCurrentStudent();
            ViewBag.StudentName = studentName.GetStudentId(id.Value);
            Intellectual_7_Class intellectual_7_Class = _repository.Get(id);
            if (intellectual_7_Class == null)
            {
                return HttpNotFound();
            }

            return View(intellectual_7_Class);
        }

        [HttpPost]
        public ActionResult Edit(Intellectual_7_Class intellectual_7_Class)
        {
            if (ModelState.IsValid)
            {
                _repository.Edit(intellectual_7_Class);
                return RedirectToAction("Index");
            }

            return View(intellectual_7_Class);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Intellectual_7_Class intellectual_7_Class = _repository.Get(id);
            if (intellectual_7_Class == null)
            {
                return HttpNotFound();
            }

            return View(intellectual_7_Class);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
