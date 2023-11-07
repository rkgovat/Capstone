//  AUTHOR:     Judy Nguyen and Megan Konvicka
//  COURSE:     ISTM 415
//  PROGRAM:    Narwhal Dental Web App
//  PURPOSE:    The service model represents Narwhal Dental service information. 
//  HONOR CODE: On my honor, as an Aggie, I have neither given 
//              nor received unauthorized aid on this academic work.

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

		public ICollection<CompletedService> CompletedServices { get; set; }
	}
}
