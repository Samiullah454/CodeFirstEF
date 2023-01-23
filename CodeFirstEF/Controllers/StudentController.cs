using CodeFirstEF.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstEF.Controllers
{
    public class StudentController : Controller
    {
        SchoolContext db = new SchoolContext();
       

        // GET: Student
        public ActionResult Index()
        {

            var v = db.Students.ToList();

           
            return View(v);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            
            var emp = db.Students.Find(id);
            return View(emp);
           
        }
        public ActionResult Create()
        {



            return View();
        }
        [HttpPost]

        public ActionResult Create(Student s)
        {
            db.Students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
           
        }
        

        
        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
           
            var emp = db.Students.Find(id);
            return View(emp);
          
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(Student s)

        {
            var data = db.Students.Find(s.StudentID);
            if(data != null)
            {
                data.StudentName = s.StudentName;
                data.DOB = s.DOB;
                data.RollNumber = s.RollNumber;
                data.Class = s.Class;

            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       
        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
       
            var  s = db.Students.Find(id);
            db.Students.Remove(s);
            db.SaveChanges();
            var list = db.Students.ToList();
            return View("Index", list);
            
           
            
        }

       
    }
}
