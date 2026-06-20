using HealiX.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealiX.Domain.Entities
{
    public class Message : BaseEntity
    {
        public int ConversationId { get; set; }

        public Conversation Conversation { get; set; } = null!;

        public int SenderId { get; set; }

        public User Sender { get; set; } = null!;

        public string MessageText { get; set; } = string.Empty;

        public DateTime SentAt { get; set; }

        public bool IsRead { get; set; }
    }
}
