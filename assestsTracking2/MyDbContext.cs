using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assestsTracking2
{
    internal class MyDbContext : DbContext
    {
        public DbSet<Assests> Assests { get; set; }
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Assests;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        //Seeding Default data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* Here we are adding seed data. 
             */
            modelBuilder.Entity<Assests>().HasData(new Assests { Id = 4, Type = "Phone", Brand = "Samsung", Model = "S5", Office = "Norway", PurchaseDate = new DateTime(2019-02-09), Currency = "EUR", Price = 500 });
            modelBuilder.Entity<Assests>().HasData(new Assests { Id = 5, Type = "Laptop", Brand = "MAc", Model = "i7", Office = "Sweden", PurchaseDate = new DateTime(2021-05-21), Currency = "EUR", Price = 500 });
            modelBuilder.Entity<Assests>().HasData(new Assests { Id = 6, Type = "Phone", Brand = "Nokia", Model = "3310", Office = "Germany", PurchaseDate = new DateTime(2019-02-08), Currency = "EUR", Price = 500 });

        }
    }
}
