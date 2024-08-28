namespace FoodService.Models.Entities
{
    public class OutboxMessage
    {
        public int Id { get; set; }
        public byte[] Message { get; set; }
        public bool Processed { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
