using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactTracing.Models
{
    public class Dose
    {
        public int ID { get; set; }

        [Display(Name ="Date and Time")]
        public DateTime dateTime { get; set; }
        public int AccountID { get; set; }

        [Display(Name = "Vaccine Type")]
        public int VaccineTypeID { get; set; }

        public Account Account { get; set; }
        public VaccineType VaccineType { get; set; }
    }
}
