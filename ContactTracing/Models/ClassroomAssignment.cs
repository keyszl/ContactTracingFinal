using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ContactTracing.Models
{
    public class ClassroomAssignment
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name ="Course")]
        public int CourseID { get; set; }

        [Display(Name = "Classroom")]
        public int ClassroomID { get; set; }

        public Course Course { get; set; }
        public Classroom Classroom { get; set; }
    }
}
