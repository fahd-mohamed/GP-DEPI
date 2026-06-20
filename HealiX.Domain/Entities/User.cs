using HealiX.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealiX.Domain.Entities
{
    internal class User : BaseEntity
    {
        public String FirstName { get; set; }
        public String LastName  { get; set; }
        public String Email  { get; set; }
        public String Password  { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; } = null!;
    }
}
