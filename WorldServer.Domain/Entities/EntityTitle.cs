using WorldServer.Domain.Entities.AbstractEntities;

public class EntityTitle
{
    public Guid Id { get; set; }

    public string Code { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public Rank Rank { get; set; }

    public List<EntityModifier> Modifiers { get; set; } = [];
}