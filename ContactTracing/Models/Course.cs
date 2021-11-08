using System;
using System.Collections.Generic;

namespace ContactTracing.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int MainClassroomID { get; set; }
        public int PeriodID { get; set; }

        public Classroom MainClassroom { get; set; }
        public Period Period { get; set; }

        public ICollection<Seating> Seatings { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
