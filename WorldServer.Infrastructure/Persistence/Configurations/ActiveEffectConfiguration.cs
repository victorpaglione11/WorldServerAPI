using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldServer.Domain.Entities;

namespace WorldServer.Infrastructure.Persistence.Configurations
{
    public class ActiveEffectConfiguration
        : IEntityTypeConfiguration<ActiveEffect>
    {
        public void Configure(EntityTypeBuilder<ActiveEffect> builder)
        {
            builder.ToTable("active_effects");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.TargetId)
                .IsRequired();

            builder.Property(x => x.StatusEffectId)
                .IsRequired();

            builder.Property(x => x.ExpiresAt)
                .IsRequired();

            builder.HasIndex(x => x.TargetId);

            builder.HasIndex(x => x.ExpiresAt);

            builder.HasOne<StatusEffect>()
                .WithMany()
                .HasForeignKey(x => x.StatusEffectId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}