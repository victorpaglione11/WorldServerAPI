using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldServer.Domain.ValueObjects;

namespace WorldServer.Infrastructure.Persistence.Extensions
{
    public static class EntityResourcesBuilderExtensions
    {
        public static ComplexPropertyBuilder<EntityResources>
            ConfigureEntityResources(
                this ComplexPropertyBuilder<EntityResources> builder)
        {
            builder.Property(x => x.CurrentHealth)
                .HasColumnName("current_health");

            builder.Property(x => x.MaxHealth)
                .HasColumnName("max_health");

            builder.Property(x => x.CurrentMana)
                .HasColumnName("current_mana");

            builder.Property(x => x.MaxMana)
                .HasColumnName("max_mana");

            return builder;
        }
    }
}