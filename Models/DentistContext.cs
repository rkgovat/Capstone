//  AUTHOR:     Judy Nguyen and Megan Konvicka
//  COURSE:     ISTM 415
//  PROGRAM:    Narwhal Dental Web App
//  PURPOSE:    The dentist context model represents Narwhal Dental dentist context information. 
//  HONOR CODE: On my honor, as an Aggie, I have neither given 
//              nor received unauthorized aid on this academic work.

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
			modelBuilder.Entity<Appointment>()
                .HasOne(p => p.Patient)
                .WithMany(a => a.Appointments);

			modelBuilder.Entity<Appointment>()
				.HasOne(d => d.Dentist)
				.WithMany(a => a.Appointments);

			modelBuilder.Entity<Appointment>()
				.HasOne(at => at.AppointmentType)
				.WithMany(a => a.Appointments);

			modelBuilder.Entity<Visit>()
				.HasOne(p => p.Patient)
				.WithMany(v => v.Visits);

			modelBuilder.Entity<Visit>()
				.HasOne(d => d.Dentist)
				.WithMany(v => v.Visits);

			modelBuilder.Entity<Patient>()
			    .HasOne(p => p.PatientHOH)  // Patient has one Head of Household
			    .WithMany(h => h.Patients)   // Head of Household can have many patients
			    .HasForeignKey(p => p.PatientHOHID); // Define the foreign key

			modelBuilder.Entity<CompletedService>()
                .HasOne(v => v.Visit)
                .WithMany(cs => cs.CompletedServices);

            modelBuilder.Entity<CompletedService>()
                .HasOne(s => s.Service)
                .WithMany(cs => cs.CompletedServices);

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
