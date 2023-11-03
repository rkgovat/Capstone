namespace DTC_Dental.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int DentistID {  get; set; }
        public int PatientID {  get; set; }
        public int TypeID {  get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeOnly StartTime {  get; set; }


    }
}
