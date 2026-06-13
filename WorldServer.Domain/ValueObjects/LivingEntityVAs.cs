namespace WorldServer.Domain.ValueObjects
{
    public record EntityAttributes
    (
        int Strength,
        int Dexterity,
        int Intelligence,
        int Perception,
        int Luck,
        int Charm
    )
    {
        public static EntityAttributes Default =>
            new(
                0, // Strength
                0, // Dexterity
                0, // Intelligence
                0, // Perception
                0, // Luck
                0  // Charm
            );
    }

    public record EntityResources
    (
        int CurrentHealth,
        int MaxHealth,
        int CurrentMana,
        int MaxMana
    )
    {
        public static EntityResources Default =>
            new(
                0, // CurrentHealth
                0, // MaxHealth
                0, // CurrentMana
                0  // MaxMana
            );
    }
}