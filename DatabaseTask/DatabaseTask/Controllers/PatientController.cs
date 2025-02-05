using Microsoft.AspNetCore.Mvc;

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
    }
}
