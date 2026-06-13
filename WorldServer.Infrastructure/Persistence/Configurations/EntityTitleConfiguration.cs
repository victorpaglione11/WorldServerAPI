using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorldServer.Infrastructure.Persistence.Configurations
{
    public class EntityTitleConfiguration
        : IEntityTypeConfiguration<EntityTitle>
    {
        public void Configure(EntityTypeBuilder<EntityTitle> builder)
        {
            builder.ToTable("titles");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(x => x.Code)
                .IsUnique();

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(x => x.Rank)
                .IsRequired();

            builder.Property(x => x.Modifiers)
                .HasColumnType("jsonb");
        }
    }
}