using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldServer.Domain.Entities;

namespace WorldServer.Infrastructure.Persistence.Configurations
{
    public class StatusEffectConfiguration
        : IEntityTypeConfiguration<StatusEffect>
    {
        public void Configure(EntityTypeBuilder<StatusEffect> builder)
        {
            builder.ToTable("status_effects");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(x => x.Code)
                .IsUnique();

            builder.Property(x => x.HasVisualEffect)
                .IsRequired();

            // JSONB for modifiers
            builder.Property(x => x.Modifiers)
                .HasColumnType("jsonb")
                .IsRequired();
        }
    }
}