using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMUni.Models
{
    public class RestrictAccess
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public SkippingAssignment SkippingAssignment { get; set; }
    }
}
