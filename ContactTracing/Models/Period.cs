using System;
using System.Collections.Generic;

namespace ContactTracing.Models
{
    public class Period
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<PeriodDay> PeriodDays { get; set; }
    }
}
