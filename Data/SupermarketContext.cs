using Microsoft.EntityFrameworkCore;
using SupermarketEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketEF.Data
{
    internal class SupermarketContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Providers> Provider { get; set; }
        public DbSet<PayMod> PayMods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=SupermarketEF;Trusted_Connection=True;");
        }
    }
}
