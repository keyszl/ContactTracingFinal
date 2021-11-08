using System;
namespace ContactTracing.Models
{
    public class PeriodDay
    {
        public int ID { get; set; }
        public int PeriodID { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan Time { get; set; }

        public Period Period { get; set; }
    }
}
