using CityBusManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBusManagementSystem.Models.Data.config
{
    public class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.HasKey(x => x.DriverId);

            builder.Property(x => x.Address)
                .HasMaxLength(256);

            builder.Property(x => x.Salary)
                .IsRequired(false);

            builder.Property(x => x.BusId)
                .IsRequired(false);

            builder.HasOne(x => x.user)
                .WithOne(x => x.driver)
                .HasForeignKey<Driver>(x => x.DriverId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.bus)
                .WithOne(x => x.driver)
                .HasForeignKey<Driver>(x => x.BusId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
