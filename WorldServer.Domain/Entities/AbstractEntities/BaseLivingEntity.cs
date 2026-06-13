using WorldServer.Domain.ValueObjects;

namespace WorldServer.Domain.Entities.AbstractEntities
{
    public class BaseLivingEntity : GameObjectEntity
    {
        public required string BaseName { get; set; }
        public Rank Tier { get; set; }
        public Guid RaceID { get; set; }
        public required EntityAttributes Attributes { get; set; }
        public required EntityResources Resources { get; set; }
    }
}
