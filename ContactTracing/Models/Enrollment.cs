using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactTracing.Models
{
    public class Enrollment
    {
        public int ID { get; set; }

        [Display(Name="Is this the course instructor?")]
        public bool Professor { get; set; }

        [Display(Name="Course")]
        public int CourseID { get; set; }

        [Display(Name="Participant")]
        public int AccountID { get; set; }

        public Course Course { get; set; }
        public Account Account { get; set; }
    }
}
