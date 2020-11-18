using Core.Domain.Customers;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.CustomerRepositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
