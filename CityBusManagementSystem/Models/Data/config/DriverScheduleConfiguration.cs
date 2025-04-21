using CityBusManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBusManagementSystem.Models.Data.config
{
    public class DriverScheduleConfiguration : IEntityTypeConfiguration<DriverSchedule>
    {
        public void Configure(EntityTypeBuilder<DriverSchedule> builder)
        {
            builder.HasKey(x => x.DriverScheduleId);
           
            builder.HasOne(x => x.driver)
                .WithMany(x => x.DriverSchedules)
                .HasForeignKey(x => x.DriverId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
