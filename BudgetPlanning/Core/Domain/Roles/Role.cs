using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Roles
{
    public class Role : BaseEntity
    {
        public int RoleTypeId { get; set; }

        public RoleType RoleType
        {
            get => (RoleType)RoleTypeId;

            set => RoleTypeId = (int) value;
        }
    }
}
