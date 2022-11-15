using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework
{
    /// <summary>
    /// Контекст
    /// </summary>
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Таблица участков
        /// </summary>
        public DbSet<Order> Orders { get; set; } = null!;

        /// <summary>
        /// Таблица кабинетов
        /// </summary>
        public DbSet<Position> Positions { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies();       // подключение lazy loading
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>()
                .HasMany(u => u.Positions)
                .WithOne(c => c.Order)
                .IsRequired();
        }
    }
}