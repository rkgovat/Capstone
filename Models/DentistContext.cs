using Microsoft.EntityFrameworkCore;

namespace DTC_Dental.Models
{
    public class DentistContext : DbContext
    {
        public DentistContext(DbContextOptions<DentistContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; } = null!;
        public DbSet<Dentist> Dentists { get; set; } = null!;
        public DbSet<Visit> Visits { get; set; } = null!;
        public DbSet<CompletedService> CompletedServices { get; set; } = null!;
        public DbSet<Service> Services { get; set; } = null!;
        public DbSet<AppointmentType> AppointmentTypes { get; set; } = null!;
        public DbSet<Appointment> Appointments { get; set; } = null!;

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // code that configures the DbContext goes here
            base.OnConfiguring(optionsBuilder);
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // code that configures the DbSet entities goes here
            //base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConfigurePatients());
            modelBuilder.ApplyConfiguration(new ConfigureDentists());
            modelBuilder.ApplyConfiguration(new ConfigureServices());
            modelBuilder.ApplyConfiguration(new ConfigureAppointmentTypes());
            modelBuilder.ApplyConfiguration(new ConfigureAppointments());
            modelBuilder.ApplyConfiguration(new ConfigureVisits());
            modelBuilder.ApplyConfiguration(new ConfigureCompletedService());
        }
    }
}
