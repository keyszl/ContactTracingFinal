using System;
using System.Collections.Generic;

namespace ContactTracing.Models
{
    public class Account
    {

        public int ID { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Professor { get; set; }
        public bool FullyVaccinated { get; set; }

        public ICollection<Test> Tests { get; set; }
        public ICollection<Dose> Doses { get; set; }
        public ICollection<Seating> Seatings { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<History> Histories { get; set; }

    }
}
