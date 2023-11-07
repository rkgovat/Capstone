//  AUTHOR:     Judy Nguyen and Megan Konvicka
//  COURSE:     ISTM 415
//  PROGRAM:    Narwhal Dental Web App
//  PURPOSE:    The configure appointments model represents Narwhal Dental appointments. 
//  HONOR CODE: On my honor, as an Aggie, I have neither given 
//              nor received unauthorized aid on this academic work.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTC_Dental.Models
{
	internal class ConfigureAppointments : IEntityTypeConfiguration<Appointment>
	{
		public void Configure(EntityTypeBuilder<Appointment> entity)
		{
			entity.HasData
			(
				new Appointment
				{
					AppointmentID = 1,
					DentistID = 1,
					PatientID = 1,
					TypeID = 1,
					AppointmentDate = DateTime.Parse("2009-11-11"),
					StartTime = TimeSpan.Parse("11:00")
				},
				new Appointment
				{
					AppointmentID = 2,
					DentistID = 2,
					PatientID = 2,
					TypeID = 2,
					AppointmentDate = DateTime.Parse("2010-11-11"),
					StartTime = TimeSpan.Parse("12:00")
				},
				new Appointment
				{
					AppointmentID = 3,
					DentistID = 3,
					PatientID = 3,
					TypeID = 3,
					AppointmentDate = DateTime.Parse("2000-11-11"),
					StartTime = TimeSpan.Parse("1:00")
				},
				new Appointment
				{
					AppointmentID = 4,
					DentistID = 4,
					PatientID = 4,
					TypeID = 4,
					AppointmentDate = DateTime.Parse("2001-11-11"),
					StartTime = TimeSpan.Parse("2:00")
				},
				new Appointment
				{
					AppointmentID = 5,
					DentistID = 5,
					PatientID = 5,
					TypeID = 5,
					AppointmentDate = DateTime.Parse("2000-1-11"),
					StartTime = TimeSpan.Parse("2:20")
				},
				new Appointment
				{
					AppointmentID = 6,
					DentistID = 1,
					PatientID = 6,
					TypeID = 6,
					AppointmentDate = DateTime.Parse("2010-11-11"),
					StartTime = TimeSpan.Parse("2:15")
				},
				new Appointment
				{
					AppointmentID = 7,
					DentistID = 2,
					PatientID = 7,
					TypeID = 7,
					AppointmentDate = DateTime.Parse("2012-11-11"),
					StartTime = TimeSpan.Parse("1:12")
				},
				new Appointment
				{
					AppointmentID = 8,
					DentistID = 3,
					PatientID = 8,
					TypeID = 8,
					AppointmentDate = DateTime.Parse("2010-12-11"),
					StartTime = TimeSpan.Parse("2:55")
				},
				new Appointment
				{
					AppointmentID = 9,
					DentistID = 4,
					PatientID = 9,
					TypeID = 9,
					AppointmentDate = DateTime.Parse("2009-01-11"),
					StartTime = TimeSpan.Parse("3:00")
				},
				new Appointment
				{
					AppointmentID = 10,
					DentistID = 5,
					PatientID = 10,
					TypeID = 10,
					AppointmentDate = DateTime.Parse("2009-11-11"),
					StartTime = TimeSpan.Parse("11:30")
				}
			);
		}
	}
}
