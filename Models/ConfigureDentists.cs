using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTC_Dental.Models
{
    internal class ConfigureDentists : IEntityTypeConfiguration<Dentist>
    {
        public void Configure(EntityTypeBuilder<Dentist> entity)
        {
            // seed initial data
            entity.HasData
            (
                new Dentist
                {
                    DentistID = 1,
                    DentistFirstName = "Jan",
                    DentistLastName = "Run",
                    HireDate = DateTime.Parse("2000-12-1")
                },
                new Dentist
                {
                    DentistID = 2,
                    DentistFirstName = "Ron",
                    DentistLastName = "Jun",
                    HireDate = DateTime.Parse("2000-11-2")
                },
                new Dentist
                {
                    DentistID = 3,
                    DentistFirstName = "Jason",
                    DentistLastName = "Fun",
                    HireDate = DateTime.Parse("2000-10-3")
                },
                new Dentist
                {
                    DentistID = 4,
                    DentistFirstName = "Jammy",
                    DentistLastName = "Dillan",
                    HireDate = DateTime.Parse("2000-09-4")
                },
                new Dentist
                {
                    DentistID = 5,
                    DentistFirstName = "Jonh",
                    DentistLastName = "Ronal",
                    HireDate = DateTime.Parse("2000-08-4")
                }
            );
        }
    }
}
