﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTC_Dental.Models
{
    internal class ConfigureCompletedService : IEntityTypeConfiguration<CompletedService>
    {
        public void Configure(EntityTypeBuilder<CompletedService> entity)
        {
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
