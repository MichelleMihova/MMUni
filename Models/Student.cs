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
            this.CompleatedCourses = new List<StudentCourse>();
            this.StudentLearningObjects = new List<StudentLearningObject>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Town { get; set; }
        public DateTime DateOfBirth { get; set; }
        [ForeignKey("LearningObject")]
        public int CurrenCourseId { get; set; }
        public LearningObject CurrentCourse { get; set; }

        //Many to many relation
        public ICollection<StudentCourse> CompleatedCourses { get; set; }
        public ICollection<StudentLearningObject> StudentLearningObjects { get; set; }
    }
}
