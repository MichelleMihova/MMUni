using MMUni.Models.Enum;
using System.Collections.Generic;

namespace MMUni.Models
{
    public class Course
    {
        public Course()
        {
            this.StudentCourses = new List<StudentCourse>();
            this.Lectures = new List<LearningObject>();
        }

        public int Id { get; set; }
        public CategoryType CategoryType { get; set; }
        public string Name { get; set; }
        public string Signature { get; set; }
        public string Description { get; set; }
        public string ParetntID { get; set; }
        public string NextCourseSignature { get; set; }
        public string SkippingCourseSignature { get; set; }
        public bool SkipCourse { get; set; }

        //public int CourseId { get; set; }
        public Program Program { get; set; }
        public SkippingAssignment SkippingAssignment { get; set; }
        public string Exam { get; set; }
        public decimal ExamGrade { get; set; }
        public decimal FinalHomeworkGrade { get; set; }
        public ICollection<LearningObject> Lectures { get; set; }

        //Many to many relation
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
