namespace play_360.EF.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? ProfilePhoto { get; set; }
        public string? Bio { get; set; }
        public bool IsPopiAccepting { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public required string IdentityNumber { get; set; }
        public required string ReferralCode { get; set; }

        public ICollection<Credit> Credits { get; } = new List<Credit>();
        public ICollection<Referral> Referrals { get; } = new List<Referral>();
        public ICollection<Media> Medias { get; } = new List<Media>();
        public ICollection<WellnessCheckin> WellnessCheckins { get; } = new List<WellnessCheckin>();
        public ICollection<UserAchievement> UserAchievements { get; } = new List<UserAchievement>();
        public ICollection<WellnessResponse> WellnessResponses { get; } = new List<WellnessResponse>();
        public ICollection<WellnessWeeklySummary> WellnessWeeklySummaries { get; } = new List<WellnessWeeklySummary>();
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public Profile? Profile { get; set; }

    }
}
