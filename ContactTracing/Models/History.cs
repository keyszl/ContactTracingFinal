using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactTracing.Models
{
    public class History
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of exposure")]
        public DateTime Exposure { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Quarantine start date")]
        public DateTime QuarantineStart { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Quarantine end date")]
        public DateTime QuarantineEnd { get; set; }
        public int AccountID { get; set; }

        public Account Account { get; set; }
    }
}
