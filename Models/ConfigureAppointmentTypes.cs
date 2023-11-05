using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTC_Dental.Models
{
    internal class ConfigureAppointmentTypes : IEntityTypeConfiguration<AppointmentType>
    {
        public void Configure(EntityTypeBuilder<AppointmentType> entity)
        {
            entity.HasData
            (
                new AppointmentType
                {
                    TypeID = 1,
                    AppointmentName = "Cosmetic Consultation - Adult",
                    Description = "Initial consultation with adult patient to discuss cosmetic dentistry options",
                    Duration = 30
                },
                new AppointmentType
                {
                    TypeID = 2,
                    AppointmentName = "Cosmetic Consultation - Child",
                    Description = "Initial consultation with child patient to discuss cosmetic dentistry options",
                    Duration = 30
                },
                new AppointmentType
                {
                    TypeID = 3,
                    AppointmentName = "Cosmetic Consultation - Teen",
                    Description = "Initial consultation with teem patient to discuss cosmetic dentistry options",
                    Duration = 30
                },
                new AppointmentType
                {
                    TypeID = 4,
                    AppointmentName = " Cosmetic Procedure - Adult",
                    Description = "Cosmetic dentistry procedure for adult patient",
                    Duration = 120
                },
                new AppointmentType
                {
                    TypeID = 5,
                    AppointmentName = "Cosmetic Procedure - Child",
                    Description = "Cosmetic dentistry procedure for child patient",
                    Duration = 120
                },
                new AppointmentType
                {
                    TypeID = 6,
                    AppointmentName = "Cosmetic Procedure - Teen",
                    Description = "Cosmetic dentistry procedure for teen patient",
                    Duration = 120
                },
                new AppointmentType
                {
                    TypeID = 7,
                    AppointmentName = "Endodontic Procedure - Adult",
                    Description = "Painless root canal therapy for adults",
                    Duration = 90
                },
                new AppointmentType
                {
                    TypeID = 8,
                    AppointmentName = " Endodontic Procedure - Child",
                    Description = "Painless root canal therapy for Children",
                    Duration = 90
                },
                new AppointmentType
                {
                    TypeID = 9,
                    AppointmentName = "Endodontic Procedure - Teen ",
                    Description = "Painless root canal therapy for Teens",
                    Duration = 90
                },
                new AppointmentType
                {
                    TypeID = 10,
                    AppointmentName = "New Patient - Adult",
                    Description = "Meet new patient with general dental check-up including x-rays and teeth cleaning",
                    Duration = 30
                },
                new AppointmentType
                {
                    TypeID = 11,
                    AppointmentName = "New Patient - Child",
                    Description = "Meet new patient with general dental check-up including x-rays and teeth cleaning",
                    Duration = 30
                },
                new AppointmentType
                {
                    TypeID = 12,
                    AppointmentName = "New Patient - Teen",
                    Description = "Meet new patient with general dental check-up including x-rays and teeth cleaning",
                    Duration = 30
                },
                new AppointmentType
                {
                    TypeID = 13,
                    AppointmentName = "Periodontal Treatment - Adult ",
                    Description = "Treatment (both preventative or restorative) for gum diseases",
                    Duration = 60
                },
                new AppointmentType
                {
                    TypeID = 14,
                    AppointmentName = "Periodontal Treatment - Child",
                    Description = "Treatment (both preventative or restorative) for gum diseases",
                    Duration = 60
                },
                new AppointmentType
                {
                    TypeID = 15,
                    AppointmentName = "Periodontal Treatment - Teen ",
                    Description = "Treatment (both preventative or restorative) for gum diseases",
                    Duration = 60
                },
                new AppointmentType
                {
                    TypeID = 16,
                    AppointmentName = "Preventative Care - Adult",  
                    Description = "General preventative care for an adult patient.The appointment will include x-rays\\54 teeth cleaning\\54 and general oral hygiene advising",
                    Duration = 60
                },
                new AppointmentType
                {
                    TypeID = 17,
                    AppointmentName = "Preventative Care - Child",
                    Description = "General preventative care for an adult patient.The appointment will include x-rays\\54 teeth cleaning\\54 and general oral hygiene advising",
                    Duration = 60
                },
                new AppointmentType
                {
                    TypeID = 18,
                    AppointmentName = "Preventative Care - Teen",
                    Description = "General preventative care for an adult patient. The appointment will include x - rays\\54 teeth cleaning\\54 and general oral hygiene advising",
                    Duration = 60
                },
                new AppointmentType
                {
                    TypeID = 19,
                    AppointmentName = "Prosthodontic Care - Adult",
                    Description = "Restoration and/or replacement of missing or damaged teeth for adults",
                    Duration = 60
                },
                new AppointmentType
                {
                    TypeID = 20,
                    AppointmentName = "Prosthodontic Care - Child",
                    Description = "Restoration and/or replacement of missing or damaged teeth for adults",
                    Duration = 60
                },
                new AppointmentType
                {
                    TypeID = 21,
                    AppointmentName = "Prosthodontic Care - Teen",
                    Description = "Restoration and/or replacement of missing or damaged teeth for adults",
                    Duration = 60
                }
            );
        }
    }
}