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

            ModelBuilder.Entity<Gadget>().HasData(new Gadget { Id = 1, Brand = "MacBook", Model = "SD", PurchaseDate = Convert.ToDateTime("2023-03-22"), Office = "Sweden", Price = 300, Currency = "SEK", ElectronicId = 1 });
            ModelBuilder.Entity<Gadget>().HasData(new Gadget { Id = 2, Brand = "Samsung", Model = "SD", PurchaseDate = Convert.ToDateTime("2022-07-02"), Office = "USA", Price = 100, Currency = "USD", ElectronicId = 2 });
            ModelBuilder.Entity<Gadget>().HasData(new Gadget { Id = 3, Brand = "Motorolla", Model = "HD", PurchaseDate = Convert.ToDateTime("2021-04-12"), Office = "India", Price = 3300, Currency = "INR", ElectronicId = 2 });
            ModelBuilder.Entity<Gadget>().HasData(new Gadget { Id = 4, Brand = "Asus", Model = "HD", PurchaseDate = Convert.ToDateTime("2023-01-14"), Office = "India", Price = 8000, Currency = "INR", ElectronicId = 1 });
            ModelBuilder.Entity<Gadget>().HasData(new Gadget { Id = 5, Brand = "HP", Model = "Note", PurchaseDate = Convert.ToDateTime("2019-09-29"), Office = "Sweden", Price = 300, Currency = "SEK", ElectronicId = 1 });
           
        }
    }
}
