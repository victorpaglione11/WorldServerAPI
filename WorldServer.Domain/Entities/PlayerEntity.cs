using WorldServer.Domain.Entities.AbstractEntities;

namespace WorldServer.Domain.Entities
{
    public class PlayerEntity : BaseLivingEntity
    {
        public Guid? ActiveTitleId { get; set; }
    }
}
