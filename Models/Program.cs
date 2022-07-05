using System.Collections.Generic;

namespace MMUni.Models
{
    public class Program
    {
        public Program()
        {
            this.StudentProgram = new List<StudentProgram>();
            this.Course = new List<Course>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Course> Course { get; set; }
        public ICollection<StudentProgram> StudentProgram { get; set; }
    }
}