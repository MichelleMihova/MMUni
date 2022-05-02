using MMUni.Models.Enum;
using System.Collections.Generic;

namespace MMUni.Models
{
    public class LearningObject
    {
        public LearningObject()
        {
            this.StudentLearningObjects = new List<StudentLearningObject>();
            this.Lectures = new List<Lecture>();
        }

        public int Id { get; set; }
        public TechnologyType TechnologyType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool SkipCourse { get; set; }
        public int ParetntID { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public SkippingAssignment SkippingAssignment { get; set; }
        public string Exam { get; set; }
        public decimal ExamGrade { get; set; }
        public decimal FinalHomeworkGrade { get; set; }
        public ICollection<Lecture> Lectures { get; set; }

        //Many to many relation
        public ICollection<StudentLearningObject> StudentLearningObjects { get; set; }
    }
}
