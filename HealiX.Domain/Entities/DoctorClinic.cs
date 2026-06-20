using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealiX.Domain.Entities
{
    internal class DoctorClinic
    {
        public int DoctorId { get; set; }
        public User Doctor { get; set; } = null!;

        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; } = null!;
    }
}
