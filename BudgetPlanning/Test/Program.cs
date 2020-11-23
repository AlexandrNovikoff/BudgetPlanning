using Autofac;
using Novikov.Core.Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Novikov.Data;
using Novikov.Data.Repositories.CustomerRepositories;
using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerBuilder builder = new ContainerBuilder();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Repositories\BudgetPlanning\BudgetPlanning\Data\Data.mdf;Integrated Security=True";
            builder.RegisterInstance(SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options);
            builder.RegisterType<BudgetPlanningDbContext>().As<DbContext>();
            IContainer r =  builder.Build();

            CustomerRepository customerRepository = new CustomerRepository(r.Resolve<DbContext>());
            
            customerRepository.Create(new Customer
            {
                Name = "Alexandr",
                Email = "123123@.com"
            });

            Console.WriteLine("Hello World!");
        }
    }
}
