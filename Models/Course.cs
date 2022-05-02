using System.Collections.Generic;

namespace MMUni.Models
{
    public class Course
    {
        public Course()
        {
            this.StudentCourses = new List<StudentCourse>();
            this.LearningObjects = new List<LearningObject>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<LearningObject> LearningObjects { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}