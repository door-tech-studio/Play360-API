namespace play_360.EF.Models
{
    public class UserSport
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SportTypeId { get; set; }
        public required string Position { get; set; }
        public int DominantSideId { get; set; }

        public User? User { get; set; }
        public SportTypes? SportType { get; set; }

    }
}