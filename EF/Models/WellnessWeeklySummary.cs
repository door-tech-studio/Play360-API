namespace play_360.EF.Models
{
    public class WellnessWeeklySummary
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime WeekStart { get; set; }
        public string AverageFeeling { get; set; }
        public int InjuryCount { get; set; }
        public string SummaryNote { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; } = null;
    }
}
