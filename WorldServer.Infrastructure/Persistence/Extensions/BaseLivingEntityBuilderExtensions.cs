using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldServer.Domain.Entities;
using WorldServer.Domain.Entities.AbstractEntities;
using WorldServer.Infrastructure.Persistence.Extensions;

namespace WorldServer.Infrastructure.Persistence.Extensions
{
    public static class BaseLivingEntityBuilderExtensions
    {
        public static EntityTypeBuilder<T>
            ConfigureBaseLivingEntity<T>(
                this EntityTypeBuilder<T> builder)
            where T : BaseLivingEntity
        {
            builder.Property(x => x.BaseName)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne<EntityRace>()
                .WithMany()
                .HasForeignKey(x => x.RaceID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Tier)
                .IsRequired();

            builder.ComplexProperty(x => x.Attributes)
                .ConfigureEntityAttributes();

            builder.ComplexProperty(x => x.Resources)
                .ConfigureEntityResources();

            builder.HasIndex(x => new
            {
                x.ChunkX,
                x.ChunkY
            });

            return builder;
        }
    }
}