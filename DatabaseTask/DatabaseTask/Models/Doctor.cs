using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int PhoneNr { get; set; }
        public string Specialty { get; set; }
    }
}
