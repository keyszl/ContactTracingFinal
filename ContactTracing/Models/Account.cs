using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactTracing.Models
{
    public class Account
    {

        public int ID { get; set; }
        public string Email { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Are you an instructor?")]
        public bool Professor { get; set; }

        [Display(Name = "Are you fully vaccinated?")]
        public bool FullyVaccinated { get; set; }

        public ICollection<Test> Tests { get; set; }
        public ICollection<Dose> Doses { get; set; }
        public ICollection<Seating> Seatings { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<History> Histories { get; set; }

    }
}
