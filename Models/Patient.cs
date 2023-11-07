//  AUTHOR:     Judy Nguyen and Megan Konvicka
//  COURSE:     ISTM 415
//  PROGRAM:    Narwhal Dental Web App
//  PURPOSE:    The patient model represents Narwhal Dental patient information. 
//  HONOR CODE: On my honor, as an Aggie, I have neither given 
//              nor received unauthorized aid on this academic work.

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DTC_Dental.Models
{
    public class Patient
    {
		public Patient()
		{
			Appointments = new HashSet<Appointment>();
			Visits = new HashSet<Visit>();
			Patients = new HashSet<Patient>();
		}


		public int PatientID { get; set; }
        
        [Required(ErrorMessage = "Please enter a first name.")]
        public string PatientFirstName { get; set;}

        [Required(ErrorMessage = "Please enter a last name.")]
        public string PatientLastName { get; set;}

        [Required(ErrorMessage = "Please enter a street address.")]
        public string PatientStreetAddress {  get; set;}

        [Required(ErrorMessage = "Please enter a city.")]
        public string PatientCity { get; set;}

        [Required(ErrorMessage = "Please enter a state.")]
        public string PatientState { get; set; }

        [Required(ErrorMessage = "Please enter a zipcode.")]
        public string PatientZip { get; set;}

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string PatientPhone { get; set;}

        [Required(ErrorMessage = "Please enter a email.")]
        public string PatientEmail { get; set;}

        public string PatientSSN { get; set;}

        [Required(ErrorMessage = "Please enter a date of birth.")]
        public DateTime PatientDOB { get; set;}

        [Required(ErrorMessage = "Please enter if patient is a minor")]
        public bool PatientMinor { get; set; }

        public int PatientHOHID { get; set;}
		public Patient PatientHOH { get; set; } = null!;

		public ICollection<Appointment> Appointments { get; set; }
		public ICollection<Visit> Visits { get; set; }
		public ICollection<Patient> Patients { get; set; }
	}
}
