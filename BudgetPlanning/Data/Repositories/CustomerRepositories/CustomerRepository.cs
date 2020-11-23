using Microsoft.EntityFrameworkCore;
using Novikov.Core.Domain.Customers;

namespace Novikov.Data.Repositories.CustomerRepositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
