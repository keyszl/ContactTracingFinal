using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactTracing.Models
{
    public class Classroom
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Length of the back of the classroom in feet")]
        public Double Length { get; set; }

        [Display(Name = "Length of the sides of the classroom in feet")]
        public Double Width { get; set; }

        public ICollection<Course> Courses { get; set; }
        public ICollection<ClassroomAssignment> ClassroomAssignments { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
