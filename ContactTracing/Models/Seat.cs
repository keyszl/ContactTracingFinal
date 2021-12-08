using System;
using System.Collections.Generic;

namespace ContactTracing.Models
{
    public class Seat
    {
        public int ID { get; set; }
        public Double XCoord { get; set; }
        public Double YCoord { get; set; }
        public Double Length { get; set; }
        public Double Width { get; set; }
        public Boolean ProfDefault { get; set; }
        public int ClassroomID { get; set; }

        public Classroom Classroom { get; set; }

        public ICollection<Seating> Seatings { get; set; }
    }
}
