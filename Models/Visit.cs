using System.ComponentModel.DataAnnotations;

namespace DTC_Dental.Models
{
    public class Visit
    {
        public int VisitID {  get; set; }

        [Required(ErrorMessage = "Please select a dentist.")]
        public int DentistID {  get; set; }

        [Required(ErrorMessage = "Please select a patient.")]
        public int PatientID {  get; set; }

        [Required(ErrorMessage = "Please select a visit date.")]
        public DateTime VisitDate { get; set; }
    }
}
