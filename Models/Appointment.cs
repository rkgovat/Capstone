//  AUTHOR:     Judy Nguyen and Megan Konvicka
//  COURSE:     ISTM 415
//  PROGRAM:    Narwhal Dental Web App
//  PURPOSE:    The appointment model represents Narwhal Dental appointments. 
//  HONOR CODE: On my honor, as an Aggie, I have neither given 
//              nor received unauthorized aid on this academic work.

using System.ComponentModel.DataAnnotations;

namespace DTC_Dental.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }

        [Required(ErrorMessage = "Please select a dentist.")]
        public int DentistID {  get; set; }
		public Dentist Dentist { get; set; } = null!;

		[Required(ErrorMessage = "Please select a patient.")]
        public int PatientID {  get; set; }
		public Patient Patient { get; set; } = null!;

		public int TypeID {  get; set; }
		public AppointmentType AppointmentType { get; set; } = null!;

		public DateTime AppointmentDate { get; set; }
        public TimeSpan StartTime {  get; set; }


    }
}
