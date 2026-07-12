using HealiX.Application.DTOs.Profile;
using Microsoft.AspNetCore.Mvc;

namespace HealiX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        [HttpGet("patient-profile")]
        public async Task<IActionResult> GetPatientProfile()
        {
            return Ok(new PatientProfileDto());
        }
    }
}