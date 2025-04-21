using CityBusManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBusManagementSystem.Models.Data.config
{
    public class TripsSchedulesConfiguration : IEntityTypeConfiguration<TripsSchedule>
    {
        public void Configure(EntityTypeBuilder<TripsSchedule> builder)
        {
            builder.HasKey(x => x.ScheduleId);

            builder.HasOne(x => x.trip)
                .WithMany(x => x.tripsSchedule)
                .HasForeignKey(x => x.TripId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
