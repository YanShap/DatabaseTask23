using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public class Hospital
    {
        [Key]
        public int HospitalID { get; set; }
        public string Adress { get; set; }
        public string Name { get; set; }
        public int Departments { get; set; }
        public int Wards { get; set; }
    }
}
