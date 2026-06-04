using WorldServer.Domain.ValueObjects;

namespace WorldServer.Domain.Entities
{
    public class WeaponEntity : BaseItemEntity
    {
        public int BaseDamage { get; set; }
        public required EntityAttributes AttributesGain { get; set; }
    }
}
