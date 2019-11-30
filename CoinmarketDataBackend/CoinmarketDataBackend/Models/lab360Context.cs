using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoinmarketDataBackend.Models
{
    public partial class lab360Context : DbContext
    {
        public lab360Context()
        {
        }

        public lab360Context(DbContextOptions<lab360Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cryptocurrency> Cryptocurrency { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-TJRUI04;Database=lab360;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cryptocurrency>(entity =>
            {
                entity.Property(e => e.CirculatingSupply).HasMaxLength(255);

                entity.Property(e => e.CryptocurrencyName).HasMaxLength(255);

                entity.Property(e => e.CryptocurrencyRank).HasMaxLength(255);

                entity.Property(e => e.CryptocurrencySymbol).HasMaxLength(255);

                entity.Property(e => e.LastUpdateTime).HasMaxLength(255);

                entity.Property(e => e.MarketCap).HasMaxLength(255);

                entity.Property(e => e.MaxSupply).HasMaxLength(255);

                entity.Property(e => e.PercentChange1h).HasMaxLength(255);

                entity.Property(e => e.PercentChange24h).HasMaxLength(255);

                entity.Property(e => e.PercentChange7d).HasMaxLength(255);

                entity.Property(e => e.Price).HasMaxLength(255);

                entity.Property(e => e.TotalSupply).HasMaxLength(255);

                entity.Property(e => e.Volume24h).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}