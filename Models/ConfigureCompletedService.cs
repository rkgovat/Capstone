//  AUTHOR:     Judy Nguyen and Megan Konvicka
//  COURSE:     ISTM 415
//  PROGRAM:    Narwhal Dental Web App
//  PURPOSE:    The completed appointment model represents Narwhal Dental completed appointments. 
//  HONOR CODE: On my honor, as an Aggie, I have neither given 
//              nor received unauthorized aid on this academic work.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTC_Dental.Models
{
    internal class ConfigureCompletedService : IEntityTypeConfiguration<CompletedService>
    {
        public void Configure(EntityTypeBuilder<CompletedService> entity)
        {
            entity.HasKey(entity => new { entity.ServiceID, entity.VisitID });

            // seed initial data
            entity.HasData
            (
                new CompletedService
                {
                    ServiceID = 1,
                    VisitID = 1
                },
                new CompletedService
                {
                    ServiceID = 2,
                    VisitID = 2
                },
                new CompletedService
                {
                    ServiceID = 3,
                    VisitID = 3
                },
                new CompletedService
                {
                    ServiceID = 4,
                    VisitID = 4
                },
                new CompletedService
                {
                    ServiceID = 5,
                    VisitID = 5
                },
                new CompletedService
                {
                    ServiceID = 6,
                    VisitID = 6
                },
                new CompletedService
                {
                    ServiceID = 7,
                    VisitID = 7
                },
                new CompletedService
                {
                    ServiceID = 8,
                    VisitID = 8
                },
                new CompletedService
                {
                    ServiceID = 9,
                    VisitID = 9

                },
                new CompletedService
                {
                    ServiceID = 10,
                    VisitID = 10
                }
            );
        }
    }
}
