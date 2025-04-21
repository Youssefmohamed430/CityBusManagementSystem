using CityBusManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBusManagementSystem.Models.Data.config
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(x => x.ClientId);

            builder.HasOne(x => x.user)
                .WithOne(x => x.client)
                .HasForeignKey<Client>(x => x.ClientId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
