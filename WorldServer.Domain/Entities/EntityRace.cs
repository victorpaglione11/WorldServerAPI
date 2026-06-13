using WorldServer.Domain.ValueObjects;

namespace WorldServer.Domain.Entities
{
    public class EntityRace
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public required EntityAttributes BaseAttributes { get; set; }
    }
}