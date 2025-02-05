using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public class Ward
    {
        [Key]
        public int WardID { get; set; }
        public int WardNr { get; set; }
        public string WardType { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
    }
}
