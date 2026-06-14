using WorldServer.Domain.Entities.AbstractEntities;

public class Title
{
    public Guid Id { get; set; }

    public string Code { get; set; } = string.Empty;

    public string TitleName { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public Rank Rank { get; set; }

    public Guid StatusEffectId { get; set; }
}