using Data.Maping;
using Microsoft.EntityFrameworkCore;

namespace Data
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
