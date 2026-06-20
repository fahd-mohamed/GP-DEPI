using HealiX.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealiX.Domain.Entities
{
    public class MedicalReport : BaseEntity
    {
        public int AppointmentId { get; set; }

        public Appointment Appointment { get; set; } = null!;

        public int CreatedBy { get; set; }

        public User Doctor { get; set; } = null!;

        public string Diagnosis { get; set; } = string.Empty;

        public string? Notes { get; set; }

        public string? Prescription { get; set; }

        public string? Recommendation { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
