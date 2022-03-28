using System.Collections.Generic;

namespace MMUni.Models
{
    public class Course
    {
        public Course()
        {
            this.Students = new List<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}