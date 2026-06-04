using Microsoft.EntityFrameworkCore;
using WorldServer.Domain.Entities;
using WorldServer.Domain.Interfaces;
using WorldServer.Infrastructure.Persistence;

namespace WorldServer.Infrastructure.Repositories
{

    public class ObjectRepository
    : IObjectRepository
    {
        private readonly WorldDbContext db;

        public ObjectRepository(
            WorldDbContext db)
        {
            this.db = db;
        }

        public async Task<List<GameObjectEntity>>
            GetChunkObjectsAsync(
                int chunkX,
                int chunkY)
        {
            return await db.GameObjects
                .Where(x =>
                    x.ChunkX == chunkX &&
                    x.ChunkY == chunkY)
                .ToListAsync();
        }

        public async Task<GameObjectEntity>
            CreateAsync(
                GameObjectEntity obj)
        {
            db.GameObjects.Add(obj);

            await db.SaveChangesAsync();

            return obj;
        }
    }
}