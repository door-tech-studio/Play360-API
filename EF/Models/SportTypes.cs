namespace play_360.EF.Models
{
    public class SportTypes
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<UserSport> UserSports { get; set; } = new List<UserSport>();
    }
}
