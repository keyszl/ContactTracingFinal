using System;
namespace ContactTracing.Models
{
    public class Dose
    {
        public int ID { get; set; }
        public DateTime dateTime { get; set; }
        public int AccountID { get; set; }
        public int VaccineTypeID { get; set; }

        public Account Account { get; set; }
        public VaccineType VaccineType { get; set; }
    }
}
