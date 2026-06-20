using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealiX.Domain.Entities
{
    internal class DoctorSpecialty
    {
        public int DoctorId { get; set; }
        public User Doctor { get; set; } = null!;

        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; } = null!;
    }
}
