using WorldServer.Domain.ValueObjects;

namespace WorldServer.Domain.Entities
{
    public class BaseLivingEntity : GameObjectEntity
    {
        public required string BaseName { get; set; }
        public Rank Tier { get; set; }
        public bool IsOnBMap { get; set; }
        public required EntityAttributes BaseAttributes { get; set; }
    }
}
