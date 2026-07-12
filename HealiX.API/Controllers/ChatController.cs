using HealiX.Application.DTOs.Chat;
using Microsoft.AspNetCore.Mvc;

namespace HealiX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        [HttpPost("send")]
        public async Task<IActionResult> SendMessage([FromForm] SendMessageDto request)
        {
            return Ok(new { Message = "Message sent successfully!" });
        }

        [HttpGet("{userId}/history")]
        public async Task<IActionResult> GetChatHistory(int userId)
        {
            return Ok(new List<MessageResponseDto>());
        }
    }
}