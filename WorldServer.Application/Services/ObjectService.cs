using WorldServer.Application.DTOs;
using WorldServer.Domain.Entities;
using WorldServer.Domain.Interfaces;

namespace WorldServer.Application.Services
{
    public class ObjectService
    {
        private readonly IObjectRepository repository;

        public ObjectService(
            IObjectRepository repository)
        {
            this.repository = repository;
        }

        public Task<List<GameObjectEntity>>
            GetChunkObjectsAsync(
                int chunkX,
                int chunkY)
        {
            return repository.GetChunkObjectsAsync(
                chunkX,
                chunkY);
        }

        public async Task<GameObjectEntity>
            CreateAsync(
                CreateObjectRequest request)
        {
            var obj =
                new GameObjectEntity
                {
                    Prefab = request.Prefab,

                    ChunkX = request.ChunkX,
                    ChunkY = request.ChunkY,

                    LocalX = request.LocalX,
                    LocalY = request.LocalY,
                    LocalZ = request.LocalZ
                };

            return await repository.CreateAsync(obj);
        }
    }
}

