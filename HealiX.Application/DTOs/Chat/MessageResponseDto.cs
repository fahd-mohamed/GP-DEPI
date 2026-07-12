namespace HealiX.Application.DTOs.Chat
{
    public class MessageResponseDto
    {
        public int MessageId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string? Content { get; set; }
        public string? AttachmentUrl { get; set; }
        public DateTime Timestamp { get; set; }
    }
}