//  AUTHOR:     Judy Nguyen and Megan Konvicka
//  COURSE:     ISTM 415
//  PROGRAM:    Narwhal Dental Web App
//  PURPOSE:    The visit model represents Narwhal Dental visits. 
//  HONOR CODE: On my honor, as an Aggie, I have neither given 
//              nor received unauthorized aid on this academic work.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTC_Dental.Models
{
	internal class ConfigureVisits : IEntityTypeConfiguration<Visit>
	{
		public void Configure(EntityTypeBuilder<Visit> entity)
		{
			entity.HasData
			(
				new Visit
				{
					VisitID = 1,
					DentistID = 1,
					PatientID = 1,
					VisitDate = DateTime.Parse("2002-08-11")
				},
				new Visit
				{
					VisitID = 2,
					DentistID = 2,
					PatientID = 2,
					VisitDate = DateTime.Parse("2019-11-01")
				},
				new Visit
				{
					VisitID = 3,
					DentistID = 3,
					PatientID = 3,
					VisitDate = DateTime.Parse("2022-11-19")
				},
				new Visit
				{
					VisitID = 4,
					DentistID = 4,
					PatientID = 4,
					VisitDate = DateTime.Parse("2020-02-03")
				},
				new Visit
				{
					VisitID = 5,
					DentistID = 5,
					PatientID = 5,
					VisitDate = DateTime.Parse("2010-12-11")
				},
				new Visit
				{
					VisitID = 6,
					DentistID = 1,
					PatientID = 6,
					VisitDate = DateTime.Parse("2008-07-07")
				},
				new Visit
				{
					VisitID = 7,
					DentistID = 2,
					PatientID = 7,
					VisitDate = DateTime.Parse("2009-09-30")
				},
				new Visit
				{
					VisitID = 8,
					DentistID = 3,
					PatientID = 8,
					VisitDate = DateTime.Parse("2001-03-23")
				},
				new Visit
				{
					VisitID = 9,
					DentistID = 4,
					PatientID = 9,
					VisitDate = DateTime.Parse("2023-06-30")
				},
				new Visit
				{
					VisitID = 10,
					DentistID = 5,
					PatientID = 10,
					VisitDate = DateTime.Parse("2017-07-20")
				}
			);
		}
	}
}
