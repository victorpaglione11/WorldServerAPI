using Microsoft.EntityFrameworkCore;
using WorldServer.Domain.Entities;

namespace WorldServer.Infrastructure.Persistence
{
    public class WorldDbContext
    : DbContext
    {
        public WorldDbContext(
            DbContextOptions<WorldDbContext> options)
            : base(options)
        {
        }

        public DbSet<GameObjectEntity>
            GameObjects =>
            Set<GameObjectEntity>();


        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameObjectEntity>()
                .ToTable("game_objects");

            modelBuilder.Entity<GameObjectEntity>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<GameObjectEntity>()
                .Property(x => x.Id)
                .HasColumnName("id");

            modelBuilder.Entity<GameObjectEntity>()
                .Property(x => x.Prefab)
                .HasColumnName("prefab");

            modelBuilder.Entity<GameObjectEntity>()
                .Property(x => x.ChunkX)
                .HasColumnName("chunk_x");

            modelBuilder.Entity<GameObjectEntity>()
                .Property(x => x.ChunkY)
                .HasColumnName("chunk_y");

            modelBuilder.Entity<GameObjectEntity>()
                .Property(x => x.LocalX)
                .HasColumnName("local_x");

            modelBuilder.Entity<GameObjectEntity>()
                .Property(x => x.LocalY)
                .HasColumnName("local_y");

            modelBuilder.Entity<GameObjectEntity>()
                .Property(x => x.LocalZ)
                .HasColumnName("local_z");
        }
    }
}

