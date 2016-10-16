using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace OSBB.Data
{
    public class DataContext : DbContext
    {

        //wraps 2 main repositories
        public DataContext()
            : base("Compact")
        {
        }

        public DbSet<Appartment> Appartments { get; set; }
        public DbSet<Occupant> Occupants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appartment>().Property(s => s.ElectricityBill).HasPrecision(18, 10);
            modelBuilder.Entity<Appartment>().Property(s => s.ElectricityPayment).HasPrecision(18, 10);
            modelBuilder.Entity<Appartment>().Property(s => s.WaterBill).HasPrecision(18, 10);
            modelBuilder.Entity<Appartment>().Property(s => s.WaterPayment).HasPrecision(18, 10);
            modelBuilder.Entity<Appartment>().Property(s => s.GasBill).HasPrecision(18, 10);
            modelBuilder.Entity<Appartment>().Property(s => s.GasPayment).HasPrecision(18, 10);
            modelBuilder.Entity<Appartment>().Property(s => s.TotalBill).HasPrecision(18, 10);
            modelBuilder.Entity<Appartment>().Property(s => s.TotalPayment).HasPrecision(18, 10);
        }
    }
}
