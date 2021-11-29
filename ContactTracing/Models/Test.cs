using System;

namespace ContactTracing.Models
{
    public class Test
    {

        public int ID { get; set; }
        public bool positive { get; set; }
        public DateTime dateTime { get; set; }
        public int AccountID { get; set; }

        public Account Account { get; set; }
    }
}
