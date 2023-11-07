//  AUTHOR:     Judy Nguyen and Megan Konvicka
//  COURSE:     ISTM 415
//  PROGRAM:    Narwhal Dental Web App
//  PURPOSE:    The dentist model represents Narwhal Dental dentist information. 
//  HONOR CODE: On my honor, as an Aggie, I have neither given 
//              nor received unauthorized aid on this academic work.

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DTC_Dental.Models
{
    public class Dentist
    {
		public Dentist()
		{
			Appointments = new HashSet<Appointment>();
			Visits = new HashSet<Visit>();

		}

		public int DentistID { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string DentistFirstName {  get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string DentistLastName { get; set; }

        public DateTime HireDate {  get; set; }

		public ICollection<Appointment> Appointments { get; set; }
		public ICollection<Visit> Visits { get; set; }
	}
}
