//  AUTHOR:     Judy Nguyen and Megan Konvicka
//  COURSE:     ISTM 415
//  PROGRAM:    Narwhal Dental Web App
//  PURPOSE:    The completed service model represents Narwhal Dental completed services. 
//  HONOR CODE: On my honor, as an Aggie, I have neither given 
//              nor received unauthorized aid on this academic work.

namespace DTC_Dental.Models
{
    public class CompletedService
    {
        public int ServiceID {  get; set; }
        public int VisitID {  get; set; }

		public Visit Visit { get; set; }
		public Service Service { get; set; }
	}
}
