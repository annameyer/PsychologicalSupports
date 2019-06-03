﻿using PagedList;
using PsychologicalSupports.Enum;
using PsychologicalSupports.Models;
using PsychologicalSupports.Models.Dependencies;
using System.Linq;
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


        public ActionResult Index(string search, string Class, int? NumberClass, int? page, string Filter)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            var students = _repository.List().Join(_psychologicalSupportsContext.Students, p => p.StudentID, x => x.StudentID, (p, x) => p).Where(x => x.Student.BeingTrained == true);
            if (!string.IsNullOrEmpty(search))
            {
                students = students.Where(x => x.Student.FIO.Contains(search));
                ViewBag.Search = search;
            }

            if (!string.IsNullOrEmpty(Class))
            {
                students = students.Where(x => x.Student.Class == Class);
                ViewBag.Class = Class;
            }

            if (NumberClass != null)
            {
                students = students.Where(x => x.Student.NumberClass == NumberClass);
                ViewBag.NumberClass = NumberClass;
            }

            if (Filter == "FIO")
            {
                students = students.OrderBy(x => x.Student.FIO);
            }

            if (Filter == "Сlass")
            {
                students = students.OrderBy(x => x.Student.Class);
            }
            ViewBag.Filter = Filter;

            return View(students.ToPagedList(pageNumber, pageSize));
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
