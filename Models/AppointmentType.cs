using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTC_Dental.Models
{
    public class AppointmentType
    {
        [Key]
        public int TypeID{  get; set; }
        public string AppointmentName {  get; set; }
        public string Description {  get; set; }
        public int Duration {  get; set; }
    }
}
