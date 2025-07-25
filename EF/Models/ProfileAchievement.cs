namespace play_360.EF.Models
{
    public class ProfileAchievement
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime AchievementDate { get; set; }
        public string Stat { get; set; }
        public Profile Profile { get; set; }
    }
}
