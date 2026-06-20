using HealiX.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealiX.Domain.Entities
{
    public class Appointment :BaseEntity
    {
        public DateTime AppointmentDate { get; set; }

        public string Status { get; set; } = string.Empty;

        public string? Notes { get; set; }

        public int UserId { get; set; }

        public User User { get; set; } = null!;
    }
}
