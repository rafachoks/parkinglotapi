using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parkinglot.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parkinglot.Data.EntityConfig
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Color).HasMaxLength(40).IsRequired();
            builder.Property(x => x.Factory).HasMaxLength(120).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.YearFactory);
        }
    }
}
