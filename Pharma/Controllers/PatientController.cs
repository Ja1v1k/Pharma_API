using Microsoft.AspNetCore.Mvc;
using Pharma.Model;
using Pharma.Services.Interfaces;

namespace Pharma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _patientService.GetAllPatient();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _patientService.GetPatientById(id);
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Patient patient)
        {
            await _patientService.AddPatient(patient);
            return CreatedAtAction(nameof(GetById), new { id = patient.Id }, patient);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id,Patient patient)
        {
            if (id != patient.Id) return BadRequest();
            await _patientService.UpdatePatient(patient);
            return NoContent();
        }

    }
}
