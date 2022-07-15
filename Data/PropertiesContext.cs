using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using build.Models;
using build.Models.Balance;
using build.Models.EventLog;
using build.Models.Inventory;
using build.Models.Tenant;
namespace build.Data
{
    public class PropertiesContext : DbContext
    {
        public PropertiesContext (DbContextOptions<PropertiesContext> options)
            : base(options)
        {
        }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
            
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property>().ToTable("Properties");
            modelBuilder.Entity<Event>().ToTable("EventLog");
            modelBuilder.Entity<Transaction>().ToTable("TransactionHistory");
            modelBuilder.Entity<Item>().ToTable("Inventory");
            modelBuilder.Entity<Tenant>().ToTable("Tenants");        
        }
    }
}
