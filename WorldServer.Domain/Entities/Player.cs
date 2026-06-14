using WorldServer.Domain.Entities.AbstractEntities;

namespace WorldServer.Domain.Entities
{
    public class Player : BaseLivingEntity
    {
        public Guid? ActiveTitleId { get; set; }
    }
}
