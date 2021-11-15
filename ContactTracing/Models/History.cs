using System;
namespace ContactTracing.Models
{
    public class History
    {
        public int ID { get; set; }
        public DateTime Exposure { get; set; }
        public DateTime QuarantineStart { get; set; }
        public DateTime QuarantineEnd { get; set; }
        public int AccountID { get; set; }

        public Account Account { get; set; }
    }
}
