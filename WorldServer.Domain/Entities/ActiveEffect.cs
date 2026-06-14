using WorldServer.Domain.Entities.AbstractEntities;

namespace WorldServer.Domain.Entities
{
    public class ActiveEffect
    {
        public Guid Id { get; set; }

        public Guid TargetId { get; set; }

        public Guid StatusEffectId { get; set; }

        public DateTime ExpiresAt { get; set; }
    }
}
