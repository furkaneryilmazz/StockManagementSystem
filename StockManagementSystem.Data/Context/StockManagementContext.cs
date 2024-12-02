using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Data.Context
{
    public class StockManagementContext : DbContext
    {
        public StockManagementContext(DbContextOptions<StockManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockUnit> StockUnits { get; set; }
        public DbSet<StockType> StockTypes { get; set; }
        public DbSet<CurrencyUnit> CurrencyUnits { get; set; }
        public DbSet<StockClass> StockClasses { get; set; }
        public DbSet<StockQuantityUnit> StockQuantityUnits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Varsa özel konfigurasyon ayarları
            modelBuilder.Entity<Stock>()
                .HasOne(s => s.StockType)
                .WithMany()
                .HasForeignKey(s => s.StockTypeId);

            modelBuilder.Entity<Stock>()
                .HasOne(s => s.StockUnit)
                .WithMany()
                .HasForeignKey(s => s.StockUnitId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
