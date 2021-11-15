using System;
using System.Collections.Generic;

namespace ContactTracing.Models
{
    public class Classroom
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Double Length { get; set; }
        public Double Width { get; set; }

        public ICollection<Course> Courses { get; set; }
        public ICollection<ClassroomAssignment> ClassroomAssignments { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
