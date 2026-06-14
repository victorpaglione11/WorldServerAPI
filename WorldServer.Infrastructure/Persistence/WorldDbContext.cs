using Microsoft.EntityFrameworkCore;
using WorldServer.Domain.Entities;
using WorldServer.Infrastructure.Migrations;

namespace WorldServer.Infrastructure.Persistence
{
    public class WorldDbContext : DbContext
    {
        public WorldDbContext(
            DbContextOptions<WorldDbContext> options)
            : base(options)
        {
        }

        public DbSet<EntityRace> Races => Set<EntityRace>();
        public DbSet<Player> Players => Set<Player>();
        public DbSet<Title> Titles => Set<Title>();
        public DbSet<PlayerTitle> PlayersTitles => Set<PlayerTitle>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(WorldDbContext).Assembly);
        }
    }
}