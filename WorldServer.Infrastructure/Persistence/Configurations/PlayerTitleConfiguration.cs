using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldServer.Domain.Entities;

namespace WorldServer.Infrastructure.Persistence.Configurations
{
    public class PlayerTitleConfiguration
        : IEntityTypeConfiguration<PlayerTitle>
    {
        public void Configure(EntityTypeBuilder<PlayerTitle> builder)
        {
            builder.ToTable("player_titles");

            builder.HasKey(x => new
            {
                x.PlayerId,
                x.TitleId
            });

            builder.Property(x => x.AchievedAt)
                .IsRequired();

            builder.HasOne<Player>()
                .WithMany()
                .HasForeignKey(x => x.PlayerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Title>()
                .WithMany()
                .HasForeignKey(x => x.TitleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(x => x.TitleId);
        }
    }
}