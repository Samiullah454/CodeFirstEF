using CodeFirstEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstEF.Controllers
{
    public class GradeController : Controller
    {
        SchoolContext db = new SchoolContext();



        // GET: Teacher
        public ActionResult Index()
        {
            var v = db.Grades.ToList();

            return View(v);
        }


        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Grade t)
        {

            db.Grades.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: Student/Details/5
        public ActionResult Details(int id)
        {

            var emp = db.Grades.Find(id);
            return View(emp);

        }
        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {

            var emp = db.Grades.Find(id);
            return View(emp);

        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(Grade s)

        {
            var data = db.Grades.Find(s.GradeId);
            if (data != null)
            {
                data.GradeName = s.GradeName;
                data.Section = s.Section;
               


            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {

            var s = db.Grades.Find(id);
            db.Grades.Remove(s);
            db.SaveChanges();
            var list = db.Grades.ToList();
            return View("Index", list);



        }
    }
}
