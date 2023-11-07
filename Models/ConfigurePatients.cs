//  AUTHOR:     Judy Nguyen and Megan Konvicka
//  COURSE:     ISTM 415
//  PROGRAM:    Narwhal Dental Web App
//  PURPOSE:    The patient model represents Narwhal Dental patients. 
//  HONOR CODE: On my honor, as an Aggie, I have neither given 
//              nor received unauthorized aid on this academic work.

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTC_Dental.Models
{
	internal class ConfigurePatients : IEntityTypeConfiguration<Patient>
	{
		public void Configure(EntityTypeBuilder<Patient> entity)
		{
			// seed initial data
			entity.HasData(
				new Patient
				{
					PatientID = 1,
					PatientFirstName = "Rohan",
					PatientLastName = "Govathoti",
					PatientStreetAddress = "101 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = "78753",
					PatientPhone = "5127787879",
					PatientEmail = "Rohan@Gmail.com",
					PatientSSN = "123456789",
					PatientDOB = DateTime.Parse("2000-01-11"),
					PatientMinor = false
				},
				new Patient
				{
					PatientID = 2,
					PatientFirstName = "Joseph",
					PatientLastName = "Pham",
					PatientStreetAddress = "102 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = "78753",
					PatientPhone = "5127787394",
					PatientEmail = "Joseph@Gmail.com",
					PatientSSN = "133456789",
					PatientDOB = DateTime.Parse("1989-02-12"),
					PatientMinor = false
				},
				new Patient
				{
					PatientID = 3,
					PatientFirstName = "Hanson",
					PatientLastName = "Nguyen",
					PatientStreetAddress = "103 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = "78753",
					PatientPhone = "5122228493",
					PatientEmail = "Hanson@Gmail.com",
					PatientSSN = "143456789",
					PatientDOB = DateTime.Parse("1978-03-13"),
					PatientMinor = false
				},
				new Patient
				{
					PatientID = 4,
					PatientFirstName = "Jason",
					PatientLastName = "Nguyen",
					PatientStreetAddress = "104 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = "78753",
					PatientPhone = "5127784905",
					PatientEmail = "Jason@Gmail.com",
					PatientSSN = "125456789",
					PatientDOB = DateTime.Parse("2000-04-14"),
					PatientMinor = false
				},
				new Patient
				{
					PatientID = 5,
					PatientFirstName = "Zahra",
					PatientLastName = "Karim",
					PatientStreetAddress = "105 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = "78753",
					PatientPhone = "5128878473",
					PatientEmail = "Zahra@Gmail.com",
					PatientSSN = "123466789",
					PatientDOB = DateTime.Parse("2000-05-15"),
					PatientMinor = false
				},
				new Patient
				{
					PatientID = 6,
					PatientFirstName = "Miley",
					PatientLastName = "Cyrus",
					PatientStreetAddress = "106 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = "78753",
					PatientPhone = "5127787473",
					PatientEmail = "Miley@Gmail.com",
					PatientSSN = "123457789",
					PatientDOB = DateTime.Parse("1997-06-16"),
					PatientMinor = false
				},
				new Patient
				{
					PatientID = 7,
					PatientFirstName = "Donal",
					PatientLastName = "Duck",
					PatientStreetAddress = "107 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = "78753",
					PatientPhone = "5124445546",
					PatientEmail = "Donal@Gmail.com",
					PatientSSN = "123459789",
					PatientDOB = DateTime.Parse("2000-07-17"),
					PatientMinor = false
				},
				new Patient
				{
					PatientID = 8,
					PatientFirstName = "Kelly",
					PatientLastName = "Tran",
					PatientStreetAddress = "108 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = "78753",
					PatientPhone = "5126635465",
					PatientEmail = "Kelly@Gmail.com",
					PatientSSN = "123456889",
					PatientDOB = DateTime.Parse("2000-08-18"),
					PatientMinor = false
				},
				new Patient
				{
					PatientID = 9,
					PatientFirstName = "Dalvin",
					PatientLastName = "Kelly",
					PatientStreetAddress = "109 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = "78753",
					PatientPhone = " 5125565686",
					PatientEmail = "Dalvin@Gmail.com",
					PatientSSN = "923456789",
					PatientDOB = DateTime.Parse("1973-09-19"),
					PatientMinor = false
				},
				new Patient
				{
					PatientID = 10,
					PatientFirstName = "Diana",
					PatientLastName = "Gutiz",
					PatientStreetAddress = "1231 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = "78753",
					PatientPhone = "5126676748",
					PatientEmail = "Diana@Gmail.com",
					PatientSSN = "103456789",
					PatientDOB = DateTime.Parse("1981-10-20"),
					PatientMinor = false
				},
				new Patient
				{
					PatientID = 11,
					PatientFirstName = "Josh",
					PatientLastName = "Drake",
					PatientStreetAddress = "10231 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = " 78753",
					PatientPhone = "5126676543",
					PatientEmail = "Josh@Gmail.com",
					PatientSSN = "113456789",
					PatientDOB = DateTime.Parse("1996-11-21"),
					PatientMinor = false
				},
				new Patient
				{
					PatientID = 12,
					PatientFirstName = "Drake",
					PatientLastName = "Josh",
					PatientStreetAddress = "241 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = "8753",
					PatientPhone = " 5127736489",
					PatientEmail = "Drake@Gmail.com",
					PatientSSN = "198456789",
					PatientDOB = DateTime.Parse("1990-12-22"),
					PatientMinor = false
				},
				new Patient
				{
					PatientID = 13,
					PatientFirstName = "Ester",
					PatientLastName = "Lovato",
					PatientStreetAddress = "141 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = "78753",
					PatientPhone = "5178673645",
					PatientEmail = "Esther@Gmail.com",
					PatientSSN = "123456789",
					PatientDOB = DateTime.Parse("2000-01-23"),
					PatientMinor = false
				},
				new Patient
				{
					PatientID = 14,
					PatientFirstName = "Daffy",
					PatientLastName = "Duck",
					PatientStreetAddress = "1271 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = "78753",
					PatientPhone = "5126954367",
					PatientEmail = "Daffy@Gmail.com",
					PatientSSN = "123456789",
					PatientDOB = DateTime.Parse("1957-02-24"),
					PatientMinor = false
				},
				new Patient
				{
					PatientID = 15,
					PatientFirstName = "Dan",
					PatientLastName = "Run",
					PatientStreetAddress = "1261 Chillip",
					PatientCity = "Austin",
					PatientState = "TX",
					PatientZip = "78753",
					PatientPhone = "3924454397",
					PatientEmail = "Dan@Gmail.com",
					PatientSSN = "123456789",
					PatientDOB = DateTime.Parse("2010-03-25"),
					PatientMinor = true,
					PatientHOHID = 1
					
				}
			);
		}
	}
}
