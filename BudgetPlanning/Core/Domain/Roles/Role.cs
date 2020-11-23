using Novikov.Core.Domain.Customers;
using System.Collections.Generic;

namespace Novikov.Core.Domain.Roles
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }

        public int RoleTypeId { get; set; }

        public RoleType RoleType
        {
            get
            {
                return (RoleType)RoleTypeId;
            }

            set
            {
                RoleTypeId = (int)value;
            }
        }

        public ICollection<Customer> Customers { get; set; }
    }
}
