namespace play_360.EF.Models
{
    public class Media
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MediaTypeId { get; set; }
        public string URL { get; set; }
        public DateTime CreatedAt { get; set; }
        public User User { get; set; } = null;
    }
}
