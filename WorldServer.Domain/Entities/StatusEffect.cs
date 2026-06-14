using WorldServer.Domain.Entities.AbstractEntities;

namespace WorldServer.Domain.Entities
{
    public class StatusEffect
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = "";
        public bool HasVisualEffect { get; set; }
        public List<EntityModifier> Modifiers { get; set; } = [];
    }
}
