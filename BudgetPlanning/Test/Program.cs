using Autofac;
using Core.Domain.Customers;
using Data;
using Data.Repositories.CustomerRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            DbContextOptions dbContextOptions = SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Repositories\BudgetPlanning\BudgetPlanning\Data\Data.mdf;Integrated Security=True").Options;
            builder.RegisterInstance<DbContextOptions>(dbContextOptions);
            IContainer r =  builder.Build();

            CustomerRepository customerRepository = new CustomerRepository(r.Resolve<DbContextOptions>());
            customerRepository.Database.EnsureCreated();
            var customer = customerRepository.GetQuery().First();
            customerRepository.Create(customer);

            Console.WriteLine("Hello World!");
        }
    }
}
