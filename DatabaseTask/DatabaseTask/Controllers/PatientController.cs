using DatabaseTask.Data;
using DatabaseTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Controllers
{
    public class PatientController : Controller
    {
        public HospitalContextDb _context;
        public IConfiguration _config { get; }

        public PatientController
            (
            HospitalContextDb context,
            IConfiguration config
            )
        {
            _context = context;
            _config = config;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IEnumerable<Patient> SearchResult()
        {
            var result = _context.Patients
                .FromSqlRaw<Patient>("spSearchPatients")
                .ToList();

            return result;
        }


    }
}
