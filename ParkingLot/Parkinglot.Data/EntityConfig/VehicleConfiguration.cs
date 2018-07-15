using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parkinglot.Domain.Entities;

namespace Parkinglot.Data.EntityConfig
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(80).IsRequired();
            builder.Property(x => x.Model).HasMaxLength(40).IsRequired();
            builder.Property(x => x.Color).HasMaxLength(40).IsRequired();
            builder.Property(x => x.Factory).HasMaxLength(120).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.YearFactory);
        }
    }
}
