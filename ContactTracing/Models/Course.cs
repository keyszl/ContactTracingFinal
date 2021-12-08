using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactTracing.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        [Display(Name = "Main Classroom")]
        public int MainClassroomID { get; set; }

        [Display(Name="Period")]
        public int PeriodID { get; set; }

        public Classroom MainClassroom { get; set; }
        public Period Period { get; set; }

        public ICollection<Seating> Seatings { get; set; }
        public ICollection<ClassroomAssignment> ClassroomAssignments { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
