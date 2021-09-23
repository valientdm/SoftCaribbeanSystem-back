using Microsoft.AspNetCore.Mvc;
using SoftCaribbeanSystem.Model.Interfaces.Services;

namespace SoftCaribbeanSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet("getPatientsRegistered")]
        public IActionResult GetPatientsRegistered()
        {
            var patientsRegistered = _patientService.GetPatientsRegistered();
            return Ok(patientsRegistered);
        }
    }
}
