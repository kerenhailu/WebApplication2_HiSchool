using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2_HiSchool.Models;

namespace WebApplication2_HiSchool.Controllers.API
{
    public class StudentApiController : ApiController
    {
        Student Student1 = new Student(0, "dan", "alon", 17, 6);
        Student Student2 = new Student(1, "shalom", "gal", 18, 6);
        Student Student3 = new Student(2, "dror", "idan", 16, 6);
        Student Student4 = new Student(3, "roni", "levi", 20, 6);
        List<Student> Students = new List<Student>()
         {
            new Student(0,"dan","alon",17,6),
            new Student(1,"shalom","gal",18,6),
            new Student(2,"dror","idan",16,6) ,
            new Student(3,"roni","levi",20,6)
        };

        // GET: api/StudentApi
        public IHttpActionResult Get()
        {
            return Ok(new { Students });
        }

        // GET: api/StudentApi/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Student OneStudent = Students.First((item) => item.id == id);
                return Ok(new { OneStudent });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        // POST: api/StudentApi
        public IHttpActionResult Post([FromBody] Student student)
        {
            try
            {
                Students.Add(student);
                return Ok(new { Students });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/StudentApi/5
        public IHttpActionResult Put(int id, [FromBody] Student studen)
        {
            try
            {
                Student studentChange = Students.First((item) => item.id == id);
                studentChange.name = studen.name;
                studentChange.lName = studen.lName;
                studentChange.age = studen.age;
                studentChange.classShcool = studen.classShcool;
                return Ok(new { Students });
            }
            catch (Exception ex)
            {
                return NotFound();
            }


        }

        // DELETE: api/StudentApi/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Student studentToRemove = Students.First((item) => item.id == id);
                Students.Remove(studentToRemove);
                return Ok(new { Students });
            }
            catch(Exception ex)
            {
                return NotFound();
            }


        }
    }
}
