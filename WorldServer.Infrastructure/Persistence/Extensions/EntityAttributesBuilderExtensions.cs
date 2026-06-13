using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldServer.Domain.ValueObjects;

namespace WorldServer.Infrastructure.Persistence.Extensions
{
    public static class EntityAttributesBuilderExtensions
    {
        public static ComplexPropertyBuilder<EntityAttributes>
            ConfigureEntityAttributes(
                this ComplexPropertyBuilder<EntityAttributes> builder)
        {
            builder.Property(x => x.Strength).HasColumnName("strength");
            builder.Property(x => x.Dexterity).HasColumnName("dexterity");
            builder.Property(x => x.Intelligence).HasColumnName("intelligence");
            builder.Property(x => x.Perception).HasColumnName("perception");
            builder.Property(x => x.Luck).HasColumnName("luck");
            builder.Property(x => x.Charm).HasColumnName("charm");

            return builder;
        }
    }
}

