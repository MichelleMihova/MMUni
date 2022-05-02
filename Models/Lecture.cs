using MMUni.Models.Enum;

namespace MMUni.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        public TechnologyType TechnologyType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VideoLessons { get; set; }
        public string ReadingLessons { get; set; }
        public string Assignments { get; set; }
        public decimal AssignmentGrade { get; set; }
        public LearningObject LearningObject { get; set; }
    }
}
