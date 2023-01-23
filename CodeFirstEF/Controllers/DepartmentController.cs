using CodeFirstEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstEF.Controllers
{
    public class DepartmentController : Controller
    {
        SchoolContext db = new SchoolContext();



        // GET: Teacher
        public ActionResult Index()
        {
            var v = db.Departments.ToList();

            return View(v);
        }


        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Department t)
        {

            db.Departments.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: Student/Details/5
        public ActionResult Details(int id)
        {

            var emp = db.Departments.Find(id);
            return View(emp);

        }
        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {

            var emp = db.Departments.Find(id);
            return View(emp);

        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(Department s)

        {
            var data = db.Departments.Find(s.DeptId);
            if (data != null)
            {
                data.DeptName = s.DeptName;
                data.DeptSubName = s.DeptSubName;
                data.DeptLocation = s.DeptLocation;


            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {

            var s = db.Departments.Find(id);
            db.Departments.Remove(s);
            db.SaveChanges();
            var list = db.Departments.ToList();
            return View("Index", list);



        }
    }
}
