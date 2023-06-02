using Microsoft.EntityFrameworkCore;
using VehicleWebApiDonet7.Models;

namespace VehicleWebApiDonet7.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Server=.;" +
                "Database=vehicledb;" +
                "Trusted_Connection=true;" +
                "TrustServerCertificate=true;"
                );
        }

        public DbSet<Boat> Boats { get; set; }

        public DbSet<Bus> Buses { get; set; }

        public DbSet<Car> Cars { get; set; }
    }
}
