namespace DTC_Dental.Models
{
    public class Visit
    {
        public int VisitID {  get; set; }
        public int DentistID {  get; set; }
        public int PatientID {  get; set; }
        public DateTime VisitDate { get; set; }
    }
}
