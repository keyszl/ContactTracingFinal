using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactTracing.Models
{
    public class Test
    {

        public int ID { get; set; }

        [Display(Name = "Was the test positive?")]
        public bool positive { get; set; }

        [Display(Name = "Date of test")]
        [DataType(DataType.Date)]
        public DateTime dateTime { get; set; }

        [Display(Name = "Account")]
        public int AccountID { get; set; }

        public Account Account { get; set; }
    }
}
