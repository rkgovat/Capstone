using System.ComponentModel.DataAnnotations;

namespace DTC_Dental.Models
{
    public class Dentist
    {
        public int DentistID { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string DentistFirstName {  get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string DentistLastName { get; set; }

        public DateTime HireDate {  get; set; }
    }
}
