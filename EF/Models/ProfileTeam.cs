namespace play_360.EF.Models
{
    public class ProfileTeam
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string TeamName { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Profile Profile { get; set; }
    }
}
