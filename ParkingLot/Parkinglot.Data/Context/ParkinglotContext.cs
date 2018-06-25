using Microsoft.EntityFrameworkCore;
using Parkinglot.Data.EntityConfig;
using Parkinglot.Domain.Entities;

namespace Parkinglot.Data.Context
{
    public class ParkinglotContext : DbContext
    {
        public ParkinglotContext(DbContextOptions<ParkinglotContext> options)
            : base(options)
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VehicleConfiguration());
        }
    }
}
