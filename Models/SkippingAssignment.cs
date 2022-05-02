using MMUni.Models.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMUni.Models
{
    public class SkippingAssignment
    {
        public SkippingAssignment()
        {
            this.Students = new List<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Grade { get; set; }
        public bool IsPassed { get; set; }
        public TechnologyType TechnologyType { get; set; }
        public string Assignment { get; set; }

        //We need student's last learning object to know where we to return him if he didn't pass the skipping assignment
        [ForeignKey("LearningObject")]
        public int LearningObjectId { get; set; }
        public LearningObject LearningObject { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
