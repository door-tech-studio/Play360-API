namespace play_360.EF.Models
{
    public class UserAchievement
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AchievementTypeId { get; set; }
        public int Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public User User { get; set; } = null;
    }
}
