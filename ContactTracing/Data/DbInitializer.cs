using ContactTracing.Models;
using System;
using System.Linq;

namespace ContactTracing.Data
{
    public class DbInitializer
    {
        public static void Initialize(ContactTracingContext context)
        {
            // Look for any students.
            if (context.Periods.Any())
            {
                return;   // DB has been seeded
            }

            var periods = new Period[]
            {
                new Period{Name="A-1"},
                new Period{Name="A-2"},
                new Period{Name="A-3"},
                new Period{Name="A-4"},
                new Period{Name="A-5"},
                new Period{Name="A-6"},
                new Period{Name="A-7"},
                new Period{Name="A-8"},
                new Period{Name="B-1"},
                new Period{Name="B-2"},
                new Period{Name="B-3"},
                new Period{Name="B-4"},
                new Period{Name="B-5"},
                new Period{Name="C-1"},
                new Period{Name="C-2"},
                new Period{Name="C-3"},
                new Period{Name="C-4"},
                new Period{Name="C-5"},
                new Period{Name="C-6"},
                new Period{Name="C-7"},
                new Period{Name="C-8"},
                new Period{Name="S-1"},
                new Period{Name="S-2"},
                new Period{Name="S-3"}
            };

            context.Periods.AddRange(periods);
            context.SaveChanges();

            var periodDays = new PeriodDay[]
            {
                new PeriodDay{PeriodID=0, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=0, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=0, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=1, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=1, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=1, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=2, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=2, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=2, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=3, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=3, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=3, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=4, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=4, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=4, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=5, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=5, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=5, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=6, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=6, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=6, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=7, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=7, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=7, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=8, Day=DayOfWeek.Tuesday, Time=TimeSpan.Parse("01:15:00")},
                new PeriodDay{PeriodID=8, Day=DayOfWeek.Thursday, Time=TimeSpan.Parse("01:15:00")},
                new PeriodDay{PeriodID=9, Day=DayOfWeek.Tuesday, Time=TimeSpan.Parse("01:15:00")},
                new PeriodDay{PeriodID=9, Day=DayOfWeek.Thursday, Time=TimeSpan.Parse("01:15:00")},
                new PeriodDay{PeriodID=10, Day=DayOfWeek.Tuesday, Time=TimeSpan.Parse("01:15:00")},
                new PeriodDay{PeriodID=10, Day=DayOfWeek.Thursday, Time=TimeSpan.Parse("01:15:00")},
                new PeriodDay{PeriodID=11, Day=DayOfWeek.Tuesday, Time=TimeSpan.Parse("01:15:00")},
                new PeriodDay{PeriodID=11, Day=DayOfWeek.Thursday, Time=TimeSpan.Parse("01:15:00")},
                new PeriodDay{PeriodID=12, Day=DayOfWeek.Tuesday, Time=TimeSpan.Parse("01:15:00")},
                new PeriodDay{PeriodID=12, Day=DayOfWeek.Thursday, Time=TimeSpan.Parse("01:15:00")},
                new PeriodDay{PeriodID=13, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=13, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=13, Day=DayOfWeek.Thursday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=13, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=14, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=14, Day=DayOfWeek.Tuesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=14, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=14, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=15, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=15, Day=DayOfWeek.Tuesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=15, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=15, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=16, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=16, Day=DayOfWeek.Tuesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=16, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=16, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=17, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=17, Day=DayOfWeek.Tuesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=17, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=17, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=18, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=18, Day=DayOfWeek.Tuesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=18, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=18, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=19, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=19, Day=DayOfWeek.Tuesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=19, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=19, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=20, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=20, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=20, Day=DayOfWeek.Thursday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=20, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("00:50:00")},
                new PeriodDay{PeriodID=21, Day=DayOfWeek.Monday, Time=TimeSpan.Parse("01:50:00")},
                new PeriodDay{PeriodID=22, Day=DayOfWeek.Wednesday, Time=TimeSpan.Parse("01:50:00")},
                new PeriodDay{PeriodID=23, Day=DayOfWeek.Friday, Time=TimeSpan.Parse("01:50:00")}
            };

            context.PeriodDays.AddRange(periodDays);
            context.SaveChanges();

            var vaccineTypes = new VaccineType[]
            {
                new VaccineType{Name="Moderna", NumDoses=2, TimeAfterLastDose=TimeSpan.Parse("14.00:00:00")},
                new VaccineType{Name="Pfizer", NumDoses=2, TimeAfterLastDose=TimeSpan.Parse("14.00:00:00")},
                new VaccineType{Name="Johnson & Johnson", NumDoses=1, TimeAfterLastDose=TimeSpan.Parse("14.00:00:00")}
            };

            context.VaccineTypes.AddRange(vaccineTypes);
            context.SaveChanges();

            var classrooms = new Classroom[]
            {
                new Classroom{Name="Mills 303", Length=34.5, Width=23.5}
            };

            context.Classrooms.AddRange(classrooms);
            context.SaveChanges();

            var seats = new Seat[]
            {
                new Seat{XCoord=5.8, YCoord=3.4, Length=2.6, Width=2.6, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=8.4, YCoord=3.4, Length=2.6, Width=2.6, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=11, YCoord=3.4, Length=2.6, Width=2.6, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=13.6, YCoord=3.4, Length=2.6, Width=2.6, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=16.2, YCoord=3.4, Length=2.6, Width=2.6, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=18.8, YCoord=3.4, Length=2.6, Width=2.6, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=21.4, YCoord=3.4, Length=2.6, Width=2.6, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=24, YCoord=3.4, Length=2.6, Width=2.6, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=26.6, YCoord=3.4, Length=2.6, Width=2.6, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=5.8, YCoord=6, Length=2.6, Width=2.4, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=5.8, YCoord=8.4, Length=2.6, Width=2.4, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=5.8, YCoord=10.8, Length=2.6, Width=2.4, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=5.8, YCoord=13.2, Length=2.6, Width=2.4, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=26.5, YCoord=6, Length=2.6, Width=2.4, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=26.5, YCoord=8.4, Length=2.6, Width=2.4, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=26.5, YCoord=10.8, Length=2.6, Width=2.4, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=26.5, YCoord=13.2, Length=2.6, Width=2.4, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=10.8, YCoord=9.4, Length=2.4, Width=2.6, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=13.2, YCoord=9.4, Length=2.4, Width=2.6, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=15.6, YCoord=9.4, Length=2.4, Width=2.6, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=18, YCoord=9.4, Length=2.4, Width=2.6, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=20.4, YCoord=9.4, Length=2.4, Width=2.6, ClassroomID=0, ProfDefault=false},
                new Seat{XCoord=11.1, YCoord=17.2, Length=5.3, Width=2.3, ClassroomID=0, ProfDefault=true}
            };

            context.Seats.AddRange(seats);
            context.SaveChanges();
        }
    }
}
