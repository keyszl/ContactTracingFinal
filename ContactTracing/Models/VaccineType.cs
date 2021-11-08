using System;
using System.Collections.Generic;

namespace ContactTracing.Models
{
    public class VaccineType
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int NumDoses { get; set; }

        public ICollection<Dose> Doses { get; set; }

    }
}
