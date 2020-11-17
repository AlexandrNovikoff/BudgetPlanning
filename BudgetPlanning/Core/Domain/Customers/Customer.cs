using Core.Domain.Roles;
using System;

namespace Core.Domain.Customers
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Login { get; set; }

        public string PhoneNumber {get;set;}

        //public Guid RoleId { get; set; }

        //public Role Role { get; set; }

    }
}
