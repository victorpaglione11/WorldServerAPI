using WorldServer.Domain.Entities;

namespace WorldServer.Domain.ValueObjects
{
    public class EntityEquipment
    {
        public Guid WeaponEntityID { get; set; }

        public virtual required WeaponEntity Weapon { get; set; }
    }
}

