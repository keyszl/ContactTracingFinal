using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactTracing.Models
{
    public class Seat
    {
        public int ID { get; set; }

        [Display(Name = "Distance from the left wall to the bottom left corner of the chair in feet")]
        public Double XCoord { get; set; }

        [Display(Name = "Distance from the back wall to the bottom left corner of the chair in feet")]
        public Double YCoord { get; set; }

        [Display(Name = "Lenth of the side of the chair parallel to the front wall in feet")]
        public Double Length { get; set; }

        [Display(Name = "Lenth of the side of the chair parallel to the side walls in feet")]
        public Double Width { get; set; }

        [Display(Name = "Is this the instructor's default seat?")]
        public bool ProfDefault { get; set; }

        [Display(Name = "Classroom")]
        public int ClassroomID { get; set; }

        public Classroom Classroom { get; set; }

        public ICollection<Seating> Seatings { get; set; }
    }
}
