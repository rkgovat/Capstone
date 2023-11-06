using System.ComponentModel.DataAnnotations;

namespace DTC_Dental.Models
{
    public class Patient
    {
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
    }
}
