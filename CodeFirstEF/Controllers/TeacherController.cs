using CodeFirstEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstEF.Controllers
{
    public class TeacherController : Controller
    {
        SchoolContext db = new SchoolContext();



        // GET: Teacher
        public ActionResult Index()
        {
            var v = db.Teachers.ToList();
          
            return View(v);
        }


        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Teacher t)
        {

            db.Teachers.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: Student/Details/5
        public ActionResult Details(int id)
        {

            var emp = db.Teachers.Find(id);
            return View(emp);

        }
        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {

            var emp = db.Teachers.Find(id);
            return View(emp);

        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(Teacher s)

        {
            var data = db.Teachers.Find(s.TeacherId);
            if (data != null)
            {
                data.TeacherName= s.TeacherName;
                data.TeacherCnic = s.TeacherCnic;
                data.TeacherSub = s.TeacherSub;
               

            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {

            var s = db.Teachers.Find(id);
            db.Teachers.Remove(s);
            db.SaveChanges();
            var list = db.Teachers.ToList();
            return View("Index", list);



        }




    }
}