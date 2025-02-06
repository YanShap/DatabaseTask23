using DatabaseTask.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class HospitalContextDb : DbContext
    {
        public HospitalContextDb(DbContextOptions<HospitalContextDb>options)
            : base(options) { }

        public DbSet<Ward> Ward { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Department> Department { get; set; }

    }
}
