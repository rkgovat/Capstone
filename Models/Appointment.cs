using System.ComponentModel.DataAnnotations;

namespace DTC_Dental.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }

        [Required(ErrorMessage = "Please select a dentist.")]
        public int DentistID {  get; set; }

        [Required(ErrorMessage = "Please select a patient.")]
        public int PatientID {  get; set; }
        public int TypeID {  get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeOnly StartTime {  get; set; }


    }
}
