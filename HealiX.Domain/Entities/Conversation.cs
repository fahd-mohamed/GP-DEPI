using HealiX.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealiX.Domain.Entities
{
    public class Conversation :BaseEntity
    {
        public DateTime CreatedAt { get; set; }

        public ICollection<ConversationParticipant> Participants { get; set; }
            = new List<ConversationParticipant>();

        public ICollection<Message> Messages { get; set; }
            = new List<Message>();
    }
}
