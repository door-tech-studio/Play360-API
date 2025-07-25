namespace play_360.EF.Models
{
    public class ProfileGoal
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string Statement { get; set; }
        public Profile Profile { get; set; }
    }
}
