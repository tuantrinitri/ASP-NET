using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web2.Models;

namespace web2.Controllers
{
    public class HomeController : Controller
    {
        IList<Student> studentList = new List<Student>(){
                            new Student() { Id = 1, Name = "Tuan",  Age = 21 } ,
                            new Student() { Id = 2, Name = "Hoang",  Age = 25 } ,
                            new Student() { Id = 3, Name = "Nam" , Age = 20 } ,
                            new Student() { Id = 4, Name = "Minh" , Age = 31 } ,
                            new Student() { Id = 5, Name = "Vân" , Age = 17 } ,
                            new Student() { Id = 6, Name = "Điệp" , Age = 19 }
                        };
        public ActionResult Index()
        {
          
            // Get the students from the database in the real application
            return View(studentList);
        }
        //Binding to Primitive type
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var std = studentList.Where(s => s.Id == Id).FirstOrDefault();
            return View(std);
        }
        [HttpPost]
        public ActionResult Edit(Student std)
        {
            Student student = new Student();
            student.Id = std.Id;
            student.Name = std.Name;
            student.Age = std.Age;

            //var Id = std.Id;
            //var Name = std.Name;
            //var Age = std.Age;

            //var courseToUpdate = studentList.Union,

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int Id)
        {
            var std = studentList.Where(s => s.Id == Id).FirstOrDefault();
            return View(std);
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Delete(int Id)
        {
              var std = studentList.Where(s => s.Id == Id).FirstOrDefault();
            return View(std);
        }
    }
}