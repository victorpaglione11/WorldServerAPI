using WorldServer.Domain.Enums;

namespace WorldServer.Domain.Entities.AbstractEntities
{
    public class BaseItemEntity
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public ItemCategory ItemCategory { get; set; }
        public Rank ItemRank { get; set; }
        public EquipmentSlot EquipmentSlot { get; set; }
    }
}
