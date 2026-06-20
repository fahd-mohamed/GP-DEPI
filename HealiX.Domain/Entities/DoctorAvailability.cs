using HealiX.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealiX.Domain.Entities
{
    public class DoctorAvailability : BaseEntity
    {
        public int DoctorId { get; set; }

        public User Doctor { get; set; } = null!;

        public string DayOfWeek { get; set; } = string.Empty;

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }
    }
}
