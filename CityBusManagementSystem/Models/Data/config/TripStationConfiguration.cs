using CityBusManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBusManagementSystem.Models.Data.config
{
    public class TripStationConfiguration : IEntityTypeConfiguration<TripStation>
    {
        public void Configure(EntityTypeBuilder<TripStation> builder)
        {
            builder.HasKey(x => x.TripStationId);

            builder.HasOne(x => x.trip)
                .WithMany(x => x.TripStations)
                .HasForeignKey(x => x.TripId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.station)
                .WithMany(x => x.TripStations)
                .HasForeignKey(x => x.StationId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
