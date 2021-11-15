using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactTracing.Models;

namespace ContactTracing.Data
{
    public class ContactTracingContext : DbContext
    {
        public ContactTracingContext (DbContextOptions<ContactTracingContext> options)
            : base(options)
        {
        }

        public DbSet<ContactTracing.Models.Account> Account { get; set; }

        public DbSet<ContactTracing.Models.Classroom> Classroom { get; set; }

        public DbSet<ContactTracing.Models.Course> Course { get; set; }

        public DbSet<ContactTracing.Models.ClassroomAssignment> ClassroomAssignment { get; set; }

        public DbSet<ContactTracing.Models.Dose> Dose { get; set; }

        public DbSet<ContactTracing.Models.Enrollment> Enrollment { get; set; }

        public DbSet<ContactTracing.Models.History> History { get; set; }

        public DbSet<ContactTracing.Models.Seating> Seating { get; set; }

        public DbSet<ContactTracing.Models.Seat> Seat { get; set; }

        public DbSet<ContactTracing.Models.Test> Test { get; set; }
    }
}
