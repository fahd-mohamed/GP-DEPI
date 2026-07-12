using HealiX.Application.DTOs.Notifications;
using Microsoft.AspNetCore.Mvc;

namespace HealiX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        [HttpGet("my-notifications")]
        public async Task<IActionResult> GetMyNotifications([FromQuery] string? filter = "All")
        {
            return Ok(new List<NotificationDto>());
        }

        [HttpPut("mark-all-read")]
        public async Task<IActionResult> MarkAllAsRead()
        {
            return Ok(new { Message = "All notifications marked as read." });
        }
    }
}