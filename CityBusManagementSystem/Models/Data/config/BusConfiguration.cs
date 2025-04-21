using CityBusManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBusManagementSystem.Models.Data.config
{
    public class BusConfiguration : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.HasKey(x => x.BusId);

            builder.Property(x => x.BusNumber)
                .IsUnicode();

            builder.ToTable("Busses");
        }
    }
}
