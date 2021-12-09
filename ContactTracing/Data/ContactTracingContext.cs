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

        public DbSet<ContactTracing.Models.Account> Accounts { get; set; }

        public DbSet<ContactTracing.Models.Classroom> Classrooms { get; set; }

        public DbSet<ContactTracing.Models.Course> Courses { get; set; }

        public DbSet<ContactTracing.Models.ClassroomAssignment> ClassroomAssignments { get; set; }

        public DbSet<ContactTracing.Models.Dose> Doses { get; set; }

        public DbSet<ContactTracing.Models.Enrollment> Enrollments { get; set; }

        public DbSet<ContactTracing.Models.History> Histories { get; set; }

        public DbSet<ContactTracing.Models.Seating> SeatingAssignments { get; set; }

        public DbSet<ContactTracing.Models.Seat> Seats { get; set; }

        public DbSet<ContactTracing.Models.Test> Tests { get; set; }

        public DbSet<ContactTracing.Models.Period> Periods { get; set; }

        public DbSet<ContactTracing.Models.PeriodDay> PeriodDays { get; set; }

        public DbSet<ContactTracing.Models.VaccineType> VaccineTypes { get; set; }
        public object Departments { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Classroom>().ToTable("Classroom");
            modelBuilder.Entity<ClassroomAssignment>().ToTable("ClassroomAssignment");
            modelBuilder.Entity<Dose>().ToTable("Dose");
            modelBuilder.Entity<History>().ToTable("History");
            modelBuilder.Entity<Seating>().ToTable("Seating");
            modelBuilder.Entity<Seat>().ToTable("Seat");
            modelBuilder.Entity<Test>().ToTable("Test");
            modelBuilder.Entity<Period>().ToTable("Period");
            modelBuilder.Entity<PeriodDay>().ToTable("PeriodDay");
            modelBuilder.Entity<VaccineType>().ToTable("VaccineType");
        }
    }
}
