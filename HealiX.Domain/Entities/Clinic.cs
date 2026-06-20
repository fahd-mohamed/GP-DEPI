using HealiX.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealiX.Domain.Entities
{
    public class Clinic :BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Address { get; set; }
        public string? Phone { get; set; }

        public ICollection<DoctorClinic> DoctorClinics { get; set; } = new List<DoctorClinic>();
    }
}
