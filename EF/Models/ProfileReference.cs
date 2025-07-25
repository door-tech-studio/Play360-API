namespace play_360.EF.Models
{
    public class ProfileReference
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string ReferenceName { get; set; }
        public string ContactInfo { get; set; }
        public string Relationship { get; set; }
        public string Role { get; set; }
        public Profile Profile { get; set; }
    }
}
