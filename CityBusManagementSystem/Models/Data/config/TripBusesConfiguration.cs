using CityBusManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBusManagementSystem.Models.Data.config
{
    public class TripBusesConfiguration : IEntityTypeConfiguration<TripBuses>
    {
        public void Configure(EntityTypeBuilder<TripBuses> builder)
        {
            builder.HasOne(x => x.trip)
                .WithMany(x => x.Tripbuses)
                .HasForeignKey(x => x.TripId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.bus)
                .WithMany(x => x.Tripbuses)
                .HasForeignKey(x => x.BusId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
