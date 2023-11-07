//  AUTHOR:     Judy Nguyen and Megan Konvicka
//  COURSE:     ISTM 415
//  PROGRAM:    Narwhal Dental Web App
//  PURPOSE:    The visit model represents Narwhal Dental visit information. 
//  HONOR CODE: On my honor, as an Aggie, I have neither given 
//              nor received unauthorized aid on this academic work.

using System.ComponentModel.DataAnnotations;

namespace DTC_Dental.Models
{
    public class Visit
    {
        public int VisitID {  get; set; }

        [Required(ErrorMessage = "Please select a dentist.")]
        public int DentistID {  get; set; }
		public Dentist Dentist { get; set; } = null!;

		[Required(ErrorMessage = "Please select a patient.")]
        public int PatientID {  get; set; }
		public Patient Patient { get; set; } = null!;

		[Required(ErrorMessage = "Please select a visit date.")]
        public DateTime VisitDate { get; set; }

		public ICollection<CompletedService> CompletedServices { get; set; }
	}
}
