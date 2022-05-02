namespace MMUni.Models
{
    public class StudentLearningObject
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int LearningObjectId { get; set; }
        public LearningObject LearningObject { get; set; }
    }
}
