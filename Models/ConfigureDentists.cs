//  AUTHOR:     Judy Nguyen and Megan Konvicka
//  COURSE:     ISTM 415
//  PROGRAM:    Narwhal Dental Web App
//  PURPOSE:    The dentist model represents Narwhal Dental dentists. 
//  HONOR CODE: On my honor, as an Aggie, I have neither given 
//              nor received unauthorized aid on this academic work.

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
					HireDate = DateTime.Parse("1985-12-1")
				},
				new Dentist
				{
					DentistID = 2,
					DentistFirstName = "Ron",
					DentistLastName = "Jun",
					HireDate = DateTime.Parse("1997-11-2")
				},
				new Dentist
				{
					DentistID = 3,
					DentistFirstName = "Jason",
					DentistLastName = "Fun",
					HireDate = DateTime.Parse("1993-10-3")
				},
				new Dentist
				{
					DentistID = 4,
					DentistFirstName = "Jammy",
					DentistLastName = "Dillan",
					HireDate = DateTime.Parse("1979-09-4")
				},
				new Dentist
				{
					DentistID = 5,
					DentistFirstName = "Jonh",
					DentistLastName = "Ronal",
					HireDate = DateTime.Parse("1988-08-4")
				}
			);
		}
	}
}
