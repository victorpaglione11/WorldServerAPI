using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldServer.Domain.Entities;
using WorldServer.Infrastructure.Persistence.Extensions;

namespace WorldServer.Infrastructure.Persistence.Configurations
{
    public class PlayerEntityConfiguration
        : IEntityTypeConfiguration<PlayerEntity>
    {
        public void Configure(EntityTypeBuilder<PlayerEntity> builder)
        {
            builder.ToTable("players");

            builder.HasKey(x => x.Id);

            builder.ConfigureBaseLivingEntity();

            builder.HasOne<EntityTitle>()
                .WithMany()
                .HasForeignKey(x => x.ActiveTitleId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<EntityTitle>()
                .WithMany()
                .HasForeignKey(x => x.ActiveTitleId);
        }
    }
}