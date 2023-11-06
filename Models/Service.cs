using System.ComponentModel.DataAnnotations;

namespace DTC_Dental.Models
{
    public class Service
    {
        public int ServiceID {  get; set; }

        [Required(ErrorMessage = "Please enter a service description.")]
        public string ServiceDescription {  get; set; }

        [Required(ErrorMessage = "Please enter a service cost.")]
        public float ServiceCost {  get; set; }
    }
}
