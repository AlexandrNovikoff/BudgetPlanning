using Core.Domain.Customers;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.CustomerRepositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
    }
}
