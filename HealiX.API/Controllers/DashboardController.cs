using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HealiX.Application.Interfaces;

namespace HealiX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;

        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [HttpGet("stats")]
        public async Task<IActionResult> GetStats()
        {
            var stats = await _dashboardService.GetStatsAsync();
            return Ok(stats);
        }

        [HttpGet("upcoming-appointments")]
        public async Task<IActionResult> GetUpcomingAppointments([FromQuery] int count = 5)
        {
            var appointments = await _dashboardService.GetUpcomingAppointmentsAsync(count);
            return Ok(appointments);
        }

        [HttpGet("recent-reports")]
        public async Task<IActionResult> GetRecentReports([FromQuery] int count = 5)
        {
            var reports = await _dashboardService.GetRecentReportsAsync(count);
            return Ok(reports);
        }
    }
}