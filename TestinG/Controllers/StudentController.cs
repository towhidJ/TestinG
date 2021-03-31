using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestinG.Getway;
using TestinG.Models;

namespace TestinG.Controllers
{
    public class StudentController : Controller
    {
        private StudentGetway studentGetway;
        private StudentDb db;
        public StudentController()
        {
            studentGetway = new StudentGetway();
            db = new StudentDb();
        }
        // GET: Student
        public ActionResult Index()
        {
            var sList = db.Students.ToList();
            return View(sList);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id,Student student)
        {
            //student = studentGetway.Edit(id);
            student = studentGetway.Edit(id);
            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        [HttpPost]
        public JsonResult AddStudent(StudentViewModel svm)
        {
            foreach (var st in svm.Students)
            {
                Student s = new Student();
                s.DepId = st.DepId;
                s.Name = st.Name;
                s.Roll = st.Roll;
                db.Students.Add(s);
                db.SaveChanges();
            }
            return Json("Your Data is save successfull placed", JsonRequestBehavior.AllowGet);

        }
    }
}
