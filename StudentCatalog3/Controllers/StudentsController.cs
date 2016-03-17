using StudentCatalog3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentCatalog2.Controllers
{
    public class StudentsController : Controller
    {
        //quick - and dirty - D.I. later
        ApplicationDbContext db =
                    new ApplicationDbContext();

        // GET: Students
        //action method
        public ActionResult Index()
        {
            List<Student> students = 
                db.Students.ToList();

            return View(students);
        }

        public string WannaPlayDad()
        {
            return "No, I am coding..";
        }

        public ActionResult MadView()
        {
            //defining Cat property
            ViewBag.Cat = "Miauu, I am a cat";

            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //Find the student from the id 
            //and send to view.

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            //set it to update the student object when you save
            db.Entry(student).State = 
                EntityState.Modified;
            
            //go back to index-view after succesful edit.

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            //if no broken rules, defined in student
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();

                return View("Thanks");
            }
            return View();

        }
    }
}