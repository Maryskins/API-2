using Microsoft.EntityFrameworkCore;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace CalculatorAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public AppDbContext() { }

        public DbSet<CalcRequest> Calculations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Для миграций
                optionsBuilder.UseSqlServer(@"Server=507-12\SQLEXPRESS;Database=CalcDb;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}