namespace MMUni.Models
{
    public class StudentProgram
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ProgramId { get; set; }
        public Program Program { get; set; }
    }
}
