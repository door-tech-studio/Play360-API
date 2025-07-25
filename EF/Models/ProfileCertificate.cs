namespace play_360.EF.Models
{
    public class ProfileCertificate
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string CertificationName { get; set; }
        public string Institution { get; set; }
        public DateTime Date { get; set; }
        public Profile Profile { get; set; }
    }
}
