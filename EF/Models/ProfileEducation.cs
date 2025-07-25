namespace play_360.EF.Models
{
    public class ProfileEducation
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string InstitutionName { get; set; }
        public string Degree { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime EndYear { get; set; }

        public Profile Profile { get; set; }
    }
}
