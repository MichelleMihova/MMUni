using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMUni.Models
{
    public class Student
    {
        public Student()
        {
            this.CompleatedPrograms = new List<StudentProgram>();
            this.StudentCourses = new List<StudentCourse>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Town { get; set; }
        public DateTime DateOfBirth { get; set; }
        [ForeignKey("Course")]
        //public int CurrenCourseId { get; set; }
        public Course CurrentCourse { get; set; }

        //Many to many relation
        public ICollection<StudentProgram> CompleatedPrograms { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
