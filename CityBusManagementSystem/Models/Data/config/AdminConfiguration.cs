using CityBusManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBusManagementSystem.Models.Data.config
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x => x.AdminId);

            builder.HasOne(x => x.user)
                .WithOne(x => x.Admin)
                .HasForeignKey<Admin>(x => x.AdminId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
