using System;
namespace ContactTracing.Models
{
    public class Enrollment
    {
        public int ID { get; set; }
        public bool Professor { get; set; }
        public int CourseID { get; set; }
        public int AccountID { get; set; }

        public Course Course { get; set; }
        public Account Account { get; set; }
    }
}
