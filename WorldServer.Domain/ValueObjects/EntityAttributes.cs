namespace WorldServer.Domain.ValueObjects
{
    public record EntityAttributes
(
    int Strength,
    int Dexterity,
    int Intelligence,
    int Vitality,
    int Agility,
    int Perception,
    int Luck
)
    {
        public static EntityAttributes Default =>
            new(
                0,
                0,
                0,
                0,
                0,
                0,
                0
            );
    }
}
