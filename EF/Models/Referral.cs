namespace play_360.EF.Models
{
    public class Referral
    {
        public int Id { get; set; }
        public int ReffererUserId { get; set; }
        public int RefferedUserId { get; set; }
        public int ReferralStatusId { get; set; }
        public string ReferralCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public User User { get; set; } = null;
    }
}
