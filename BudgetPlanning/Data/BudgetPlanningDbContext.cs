using Novikov.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Novikov.Data
{
    public class BudgetPlanningDbContext : DbContext
    {
        public BudgetPlanningDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
