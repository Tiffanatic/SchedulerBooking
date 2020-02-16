

using CouncelingScheduler.domain.domain;

namespace CouncelingScheduler.Application.DbContext
{
    using Microsoft.EntityFrameworkCore;
    using CouncelingScheduler.domain.domain;
    public class CouncelingSchedulerContext : DbContext
    {
        public CouncelingSchedulerContext(DbContextOptions<CouncelingSchedulerContext> options) : base(options)
        {
            
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Hold> Holds { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Timeslot> Timeslots { get; set; }

    }
}