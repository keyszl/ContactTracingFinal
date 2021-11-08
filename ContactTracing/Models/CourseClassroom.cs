using System;
namespace ContactTracing.Models
{
    public class CourseClassroom
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int CourseID { get; set; }
        public int ClassroomID { get; set; }

        public Course Course { get; set; }
        public Classroom Classroom { get; set; }
    }
}
