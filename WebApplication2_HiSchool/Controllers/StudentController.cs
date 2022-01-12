using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2_HiSchool.Models;

namespace WebApplication2_HiSchool.Controllers
{
    public class StudentController : Controller
    {
        Student Student1 = new Student(0, "dan", "alon", 17, 6);
        Student Student2 = new Student(1, "shalom", "gal", 18, 6);
        Student Student3 = new Student(2, "dror", "idan", 16, 6);
        Student Student4 = new Student(3, "roni", "levi", 20, 6);
        Student[] students = new Student[] {
            new Student(0,"dan","alon",17,6),
            new Student(1,"shalom","gal",18,6),
            new Student(2,"dror","idan",16,6) ,
            new Student(3,"roni","levi",20,6)
        };

        // GET: Student
        public ActionResult ShowS()
        {
            return View(students);
        }

        public ActionResult Index(int Id)
        {
            foreach (Student student in students)
            {
                if (Id == student.id)
                {
                    return View(student);
                }
            }
            return View("null");
        }


    }
}