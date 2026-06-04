using WorldServer.Domain.Entities;

namespace WorldServer.Domain.Interfaces
{
    public interface IObjectRepository
    {
        Task<List<GameObjectEntity>>
            GetChunkObjectsAsync(
                int chunkX,
                int chunkY);

        Task<GameObjectEntity>
            CreateAsync(
                GameObjectEntity obj);
    }
}

