using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace HealiX.Application.DTOs.Chat
{
    public class SendMessageDto
    {
        [Required]
        public int ReceiverId { get; set; }

        public string? Content { get; set; }

        public IFormFile? Attachment { get; set; }
    }
}