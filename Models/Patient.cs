namespace DTC_Dental.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientFirstName { get; set;}
        public string PatientLastName { get; set;}
        public string PatientStreetAddress {  get; set;}
        public string PatientCity { get; set;}
        public string PatientState { get; set; }
        public string PatientZip { get; set;}
        public string PatientPhone { get; set;}
        public string PatientEmail { get; set;}
        public string PatientSSN { get; set;}
        public DateTime PatientDOB { get; set;}
        public bool PatientMinor { get; set; }
        public int PatientHOHlD { get; set;}
    }
}
