using MMUni.Models.Enum;

namespace MMUni.Models
{
    public class LearningObject
    {
        public int Id { get; set; }
        public CategoryType CategoryType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VideoLessons { get; set; }
        public string ReadingLessons { get; set; }
        public string Assignments { get; set; }
        public decimal AssignmentGrade { get; set; }
        public Course Course { get; set; }
    }
}
