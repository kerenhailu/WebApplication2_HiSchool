using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2_HiSchool.Models
{
    public class Student
    {
        public int id;
        public string name;
        public string lName;
        public int age;
        public int classShcool;

        public Student(int id, string name, string lName, int age, int classShcool)
        {
            this.id = id;
            this.name = name;
            this.lName = lName;
            this.age = age;
            this.classShcool = classShcool;
        }
    }
}