using System.Collections.Generic;

namespace MMUni.Models
{
    public class Course
    {
        public Course()
        {
            this.StudentCourses = new List<StudentCourse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}