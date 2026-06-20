using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealiX.Domain.Entities
{
    public class DoctorProfile
    {
        public int DoctorId { get; set; }

        public User Doctor { get; set; } = null!;

        public decimal ConsultationFee { get; set; }

        public string? Bio { get; set; }

        public int YearsOfExperience { get; set; }

        public bool IsAvailable { get; set; }
    }
}
