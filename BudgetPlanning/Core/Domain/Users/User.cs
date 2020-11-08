using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Roles;

namespace Core.Domain.Users
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public int RoleTypeId { get; set; }
    }
}
