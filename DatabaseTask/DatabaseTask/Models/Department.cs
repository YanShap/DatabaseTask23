using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentSpecalty { get; set; }
        public int DoctorID { get; set; }

    }
}
