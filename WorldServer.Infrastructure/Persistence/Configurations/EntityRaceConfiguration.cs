using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldServer.Domain.Entities;
using WorldServer.Infrastructure.Persistence.Extensions;

namespace WorldServer.Infrastructure.Persistence.Configurations
{
    public class EntityRaceConfiguration
        : IEntityTypeConfiguration<EntityRace>
    {
        public void Configure(EntityTypeBuilder<EntityRace> builder)
        {
            builder.ToTable("races");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Description)
                .HasMaxLength(1000);

            builder.HasIndex(x => x.Name)
                .IsUnique();
           
            builder.ComplexProperty(x => x.BaseAttributes)
                .ConfigureEntityAttributes();
        }
    }
}