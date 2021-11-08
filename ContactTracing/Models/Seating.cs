using System;
namespace ContactTracing.Models
{
    public class Seating
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int CourseID { get; set; }
        public int AccountID { get; set; }
        public int SeatID { get; set; }

        public Course Course { get; set; }
        public Account Account { get; set; }
        public Seat Seat { get; set; }
    }
}
