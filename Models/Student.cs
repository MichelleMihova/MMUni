using System;
using System.Collections.Generic;

namespace MMUni.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new List<Course>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Town { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
