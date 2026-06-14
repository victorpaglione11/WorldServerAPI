namespace WorldServer.Domain.Entities
{
    public class PlayerTitle
    {
        public long PlayerId { get; set; }

        public Guid TitleId { get; set; }

        public DateTime AchievedAt { get; set; }


    }
}
