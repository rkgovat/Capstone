//  AUTHOR:     Judy Nguyen and Megan Konvicka
//  COURSE:     ISTM 415
//  PROGRAM:    Narwhal Dental Web App
//  PURPOSE:    The appointment type model represents Narwhal Dental appointment types. 
//  HONOR CODE: On my honor, as an Aggie, I have neither given 
//              nor received unauthorized aid on this academic work.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTC_Dental.Models
{
    public class AppointmentType
    {
        public AppointmentType()
        {
            Appointments = new HashSet<Appointment>();
        }

		[Key]
        public int TypeID{  get; set; }
        public string AppointmentName {  get; set; }
        public string Description {  get; set; }
        public int Duration {  get; set; }

		public ICollection<Appointment> Appointments { get; set; }
	}
}
