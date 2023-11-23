using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssetsTracking
{
    internal class MyDbContext : DbContext
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFAssetsTracking;Integrated Security=True";

        public DbSet<Electronic> Electronics { get; set; } // create Electronics Table in DB
        public DbSet<Gadget> Gadgets { get; set; }  // create Gadgets Table in DB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We tell the app to use the connectionstring.
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Electronic>().HasData(new Electronic { Id = 1, Type = "Computer" });
            ModelBuilder.Entity<Electronic>().HasData(new Electronic { Id = 2, Type = "Mobile" });
           
        }
    }
}
