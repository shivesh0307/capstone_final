using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bank.Entities;
using Microsoft.EntityFrameworkCore;
namespace bank.Database
{
    public class BankdbContext:DbContext
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<admin> admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define connection string.
            optionsBuilder.UseSqlServer(@"Data Source=WINDOWS-UNR7VLH\SQLEXPRESS;Initial Catalog=Bank3;Integrated Security=True");
        }
    }
}
