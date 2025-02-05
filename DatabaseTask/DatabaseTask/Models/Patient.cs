using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int PhoneNr { get; set; }
        public string CheckInDate { get; set; }
        public string DepartureDate { get; set; }
        public int DoctorID { get; set; }
        public int WardID { get; set; }
    }
}
