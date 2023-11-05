using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTC_Dental.Models
{
    internal class ConfigureServices : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> entity)
        {
            entity.HasData
            (
                new Service
                {
                    ServiceID = 1,
                    ServiceDescription = "X-Ray",
                    ServiceCost = 250
                },
                new Service
                {
                    ServiceID = 2,
                    ServiceDescription = "Drill Cavity",
                    ServiceCost = 350
                },
                new Service
                {
                    ServiceID = 3,
                    ServiceDescription = "Crown",
                    ServiceCost = 750
                },
                new Service
                {
                    ServiceID = 4,
                    ServiceDescription = "Extract Tooth",
                    ServiceCost = 500
                },
                new Service
                {
                    ServiceID = 5,
                    ServiceDescription = "Root Canal",
                    ServiceCost = 1500
                },
                new Service
                {
                    ServiceID = 6,
                    ServiceDescription = "Tooth Whitening",
                    ServiceCost = 350
                },
                new Service
                {
                    ServiceID = 7,
                    ServiceDescription = "Dental Implant",
                    ServiceCost = 2500
                },
                new Service
                {
                    ServiceID = 8,
                    ServiceDescription = "Dentures",
                    ServiceCost = 4500
                },
                new Service
                {
                    ServiceID = 9,
                    ServiceDescription = "Anesthetic",
                    ServiceCost = 250
                },
                new Service
                {
                    ServiceID = 10,
                    ServiceDescription = "Cleaning",
                    ServiceCost = 150
                },
                new Service
                {
                    ServiceID = 11,
                    ServiceDescription = "Pediatric Dental Care",
                    ServiceCost = 350
                },
                new Service
                {
                    ServiceID = 12,
                    ServiceDescription = "Dental Extraction",
                    ServiceCost = 500
                },
                new Service
                {
                    ServiceID = 13,
                    ServiceDescription = "Dental Screening",
                    ServiceCost = 250
                },
                new Service
                {
                    ServiceID = 14,
                    ServiceDescription = "Fluoride Treatment",
                    ServiceCost = 275
                },
                new Service
                {
                    ServiceID = 15,
                    ServiceDescription = "Cavity Filling",
                    ServiceCost = 250
                }
            );
        }
    }
}
